namespace ProjectAirplane.CollectionGenericObjects;

/// <summary>
/// Класс-хранилище коллекций
/// </summary>
/// <typeparam name="T"></typeparam>
public class StorageCollection<T> where T : class
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
  public ICollectionGenericObjects<T>? this[string name]
  {
    get
    {
      return _storages.GetValueOrDefault(name, null);
    }
  }
}