﻿using ProjectAirplane.Drawings;
using ProjectAirplane.Exceptions;
using System.Text;

namespace ProjectAirplane.CollectionGenericObjects;

/// <summary>
/// Класс-хранилище коллекций
/// </summary>
/// <typeparam name="T"></typeparam>
public class StorageCollection<T> where T : DrawingAirplane
{
  /// <summary>
  /// Словарь (хранилище) с коллекциями
  /// </summary>
  readonly Dictionary<string, ICollectionGenericObjects<T>> _storages;

  /// <summary>
  /// Возвращение списка названий коллекций
  /// </summary>
  public List<string> Keys => _storages.Keys.ToList();

  /// <summary>
  /// Конструктор
  /// </summary>
  public StorageCollection()
  {
    _storages = new Dictionary<string, ICollectionGenericObjects<T>>();
  }

  /// <summary>
  /// Ключевое слово, с которого должен начинаться файл
  /// </summary>
  private readonly string _collectionKey = "CollectionsStorage";

  /// <summary>
  /// Разделитель для записи ключа и значения элемента словаря
  /// </summary>
  private readonly string _separatorForKeyValue = "|";

  /// <summary>
  /// Разделитель для записей коллекции данных в файл
  /// </summary>
  private readonly string _separatorItems = ";";

  /// <summary>
  /// Добавление коллекции в хранилище
  /// </summary>
  /// <param name="name">Название коллекции</param>
  /// <param name="collectionType">Тип коллекции</param>
  public void AddCollection(string name, CollectionType collectionType)
  {
    if (name == null || Keys.Contains(name))
    {
      return;
    }
    switch (collectionType)
    {
      case CollectionType.Massive:
        _storages.Add(name, new MassiveGenericObjects<T>());
        break;
      case CollectionType.List:
        _storages.Add(name, new ListGenericObjects<T>());
        break;
      case CollectionType.None:
        break;
    }
  }

  /// <summary>
  /// Удаление коллекции
  /// </summary>
  /// <param name="name">Название коллекции</param>
  public void DelCollection(string name)
  {
    if (name == null || !Keys.Contains(name))
    {
      return;
    }
    _storages.Remove(name);
  }

  /// <summary>
  /// Доступ к коллекции
  /// </summary>
  /// <param name="name">Название коллекции</param>
  /// <returns></returns>
  public ICollectionGenericObjects<T>? this[string name] => _storages.GetValueOrDefault(name, null);
  /// <summary>
  /// Сохранение информации по самолетам в хранилище в файл
  /// </summary>
  /// <param name="filename">Путь и имя файла</param>
  /// <returns>true - сохранение прошло успешно, false - ошибка при сохранении данных</returns>
  public void SaveData(string filename)
  {
    if (_storages.Count == 0)
    {
      throw new Exception("В хранилище отсутствуют коллекции для сохранения");
    }

    if (File.Exists(filename))
    {
      File.Delete(filename);
    }

    StringBuilder sb = new();

    sb.Append(_collectionKey);
    foreach (KeyValuePair<string, ICollectionGenericObjects<T>> value in _storages)
    {
      sb.Append(Environment.NewLine);
      // не сохраняем пустые коллекции
      if (value.Value.Count == 0)
      {
        continue;
      }

      sb.Append(value.Key);
      sb.Append(_separatorForKeyValue);
      sb.Append(value.Value.GetCollectionType);
      sb.Append(_separatorForKeyValue);
      sb.Append(value.Value.MaxCount);
      sb.Append(_separatorForKeyValue);

      foreach (T? item in value.Value.GetItems())
      {
        string data = item?.GetDataForSave() ?? string.Empty;
        if (string.IsNullOrEmpty(data))
        {
          continue;
        }

        sb.Append(data);
        sb.Append(_separatorItems);
      }
    }

    using FileStream fs = new(filename, FileMode.Create);
    byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
    fs.Write(info, 0, info.Length);
  }

  /// <summary>
  /// Загрузка информации по автомобилям в хранилище из файла
  /// </summary>
  /// <param name="filename">Путь и имя файла</param>
  public void LoadData(string filename)
  {
    if (!File.Exists(filename))
    {
      throw new Exception("Файл не существует");
    }

    string bufferTextFromFile = "";
    using (FileStream fs = new(filename, FileMode.Open))
    {
      byte[] b = new byte[fs.Length];
      UTF8Encoding temp = new(true);
      while (fs.Read(b, 0, b.Length) > 0)
      {
        bufferTextFromFile += temp.GetString(b);
      }
    }

    string[] strs = bufferTextFromFile.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    if (strs == null || strs.Length == 0)
    {
      throw new Exception("В файле нет данных");
    }

    if (!strs[0].Equals(_collectionKey))
    {
      //если нет такой записи, то это не те данные
      throw new Exception("В файле неверные данные");
    }

    _storages.Clear();
    foreach (string data in strs)
    {
      string[] record = data.Split(_separatorForKeyValue, StringSplitOptions.RemoveEmptyEntries);
      if (record.Length != 4)
      {
        continue;
      }

      CollectionType collectionType = (CollectionType)Enum.Parse(typeof(CollectionType), record[1]);
      ICollectionGenericObjects<T>? collection = StorageCollection<T>.CreateCollection(collectionType) ??
          throw new Exception("Не удалось определить тип коллекции:" + record[1]);

      collection.MaxCount = Convert.ToInt32(record[2]);

      string[] set = record[3].Split(_separatorItems, StringSplitOptions.RemoveEmptyEntries);
      foreach (string elem in set)
      {
        if (elem?.CreateDrawingAirplane() is T airplane)
        {
          try
          {
            if (!collection.Insert(airplane))
            {
              throw new Exception("Объект не удалось добавить в коллекцию: " + record[3]);
            }
          }
          catch (CollectionOverflowException ex)
          {
            throw new Exception("Коллекция переполнена", ex);
          }
        }
      }

      _storages.Add(record[0], collection);
    }


  }

  /// <summary>
  /// Создание коллекции по типу
  /// </summary>
  /// <param name="collectionType"></param>
  /// <returns></returns>
  private static ICollectionGenericObjects<T>? CreateCollection(CollectionType collectionType)
  {
    return collectionType switch
    {
      CollectionType.Massive => new MassiveGenericObjects<T>(),
      CollectionType.List => new ListGenericObjects<T>(),
      _ => null,
    };
  }
}