namespace ProjectAirplane.CollectionGenericObjects;

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

    // проверка позиции
    /*if (position < 0 || position >= Count) return null;
    return _collection[position];*/
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

    // вставка в свободное место набора
    /*int index = 0;
    while (_collection[index] != null)
    {
      index++;
      if (index == Count) { return true; } // false?
    }

    while (index != 0)
    {
      _collection[index] = _collection[index - 1];
      index--;
    }
    _collection[0] = obj;
    return false;*/
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
    /*if (position >= 0 && position < _collection.Length)
    {
      if (_collection[position] == null)
      {
        _collection[position] = obj;
        return true;
      }

      for (int i = position + 1; i < _collection.Length; i++)
      {
        if (_collection[i] == null)
        {
          _collection[i] = obj;
          return true;
        }
      }
    }

    return false;*/


    //  проверка позиции
    //  проверка, что элемент массива по этой позиции пустой, если нет, то
    //		ищется свободное место после этой позиции и идет вставка туда
    //		если нет после, ищем до
    //  вставка
    /*if (position < 0 || position >= Count)
    {
      return false;
    }
    if (_collection[position] == null)
    {
      _collection[position] = obj;
      return true;
    }
    int index = position;
    while (_collection[index] != null) index++;
    if (index == Count) return false;
    for (int i = index; i > position; i--)
    {
      _collection[i] = _collection[i - 1];
    }
    _collection[position] = obj;
    return true;*/
  }

  public bool Remove(int position)
  {
    if (position >= 0 && position < _collection.Length)
    {
      _collection[position] = null;
      return true;
    }

    return false;


    //  проверка позиции
    //  удаление объекта из массива, присвоив элементу массива значение null
    /*if (position < 0 || position >= Count) return false;
    _collection[position] = null;
    return true;*/
  }
}

