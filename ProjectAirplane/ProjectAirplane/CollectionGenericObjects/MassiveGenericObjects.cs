﻿namespace ProjectAirplane.CollectionGenericObjects;

/// <summary>
/// Параметризованный набор объектов
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public class MassiveGenericObjects<T> : ICollectionGenericObjects<T> where T : class
{
  /// <summary>
  /// Массив объектов, которые храним
  /// </summary>
  private T?[] _collection;
  public int Count => _collection.Length;

  public int SetMaxCount
  {
    set
    {
      if (value > 0)
      {
        if (_collection.Length > 0)
        {
          Array.Resize(ref _collection, value);
        }
        else
        {
          _collection = new T?[value];
        }
      }
    }
  }

  /// <summary>
  /// Конструктор
  /// </summary>
  public MassiveGenericObjects()
  {
    _collection = Array.Empty<T>();
  }

  public T? Get(int position)
  {
    if (position >= 0 && position < _collection.Length)
    {
      return _collection[position];
    }

    return null;
  }

  public bool Insert(T obj)
  {
    if (obj == null)
    {
      return false;
    }

    for (int i = 0; i < _collection.Length; i++)
    {
      if (_collection[i] == null)
      {
        _collection[i] = obj;
        return true;
      }
    }

    return false;
  }

  public bool Insert(T obj, int position)
  {
    for (int i = 0; i < _collection.Length; i++)
    {
      if (_collection[i] == null)
      {
        _collection[i] = obj;
        return true;
      }
    }
    return false;
  }

  public bool Remove(int position)
  {
    if (position >= 0 && position < _collection.Length)
    {
      _collection[position] = null;
      return true;
    }

    return false;
  }
}

