using ProjectAirplane.Drawings;

namespace ProjectAirplane.CollectionGenericObjects;

/// <summary>
/// Абстракция компании, хранящий коллекцию автомобилей
/// </summary>
public abstract class AbstractCompany
{
  /// <summary>
  /// Размер места (ширина)
  /// </summary>
  protected readonly int _placeSizeWidth = 90;//85;
  /// <summary>
  /// Размер места (высота)
  /// </summary>
  protected readonly int _placeSizeHeight = 80;//74;
  /// <summary>
  /// Ширина окна
  /// </summary>
  protected readonly int _pictureWidth;

  /// <summary>
	/// Высота окна
  /// </summary>
  protected readonly int _pictureHeight;

  /// <summary>
  /// Коллекция автомобилей
  /// </summary>
  protected ICollectionGenericObjects<DrawingAirplane>? _collection = null;
  /// <summary>
  /// Вычисление максимального количества элементов, который можно разместить в окне
  /// </summary>
  private int GetMaxCount => (_pictureWidth / _placeSizeWidth) * (_pictureHeight / _placeSizeHeight);

  /// <summary>
  /// Конструктор
  /// </summary>
  /// <param name="picWidth">Ширина окна</param>
  /// <param name="picHeight">Высота окна</param>
  /// <param name="collection">Коллекция автомобилей</param>
  public AbstractCompany(int picWidth, int picHeight, ICollectionGenericObjects<DrawingAirplane> collection)
  {
    _pictureWidth = picWidth;
    _pictureHeight = picHeight;
    _collection = collection;
    _collection.SetMaxCount = GetMaxCount;

  }
  /// <summary>
  /// Перегрузка оператора сложения для класса
  /// </summary>
  /// <param name="company">Компания</param>
  /// <param name="airplane">Добавляемый объект</param>
  /// <returns></returns>
  public static bool operator +(AbstractCompany company, DrawingAirplane airplane)
  {
    return company._collection?.Insert(airplane) ?? false;
  }

  /// <summary>
  /// Перегрузка оператора удаления для класса
  /// </summary>
  /// <param name="company">Компания</param>
  /// <param name="position">Номер удаляемого объекта</param>
  /// <returns></returns>
  public static bool operator -(AbstractCompany company, int position)
  {
    return company._collection?.Remove(position) ?? false;
  }

  /// <summary>
  /// Получение случайного объекта из коллекции
  /// </summary>
  /// <returns></returns>
  public DrawingAirplane? GetRandomObject()
  {
    Random rnd = new();
    return _collection?.Get(rnd.Next(GetMaxCount));
  }

  /// <summary>
  /// Вывод всей коллекции
  /// </summary>
  /// <returns></returns>
  public Bitmap? Show()
  {
    Bitmap bitmap = new(_pictureWidth, _pictureHeight);
    Graphics graphics = Graphics.FromImage(bitmap);
    DrawBackground(graphics);

    SetObjectsPosition();
    for (int i = 0; i < (_collection?.Count ?? 0); ++i)
    {
      DrawingAirplane? obj = _collection?.Get(i);
      obj?.DrawTransport(graphics);
    }
    return bitmap;
  }

  /// <summary>
  /// Вывод заднего фона
  /// </summary>
  /// <param name="g"></param>
  protected abstract void DrawBackground(Graphics g);

  /// <summary>
  /// Расстановка объектов
  /// </summary>
  protected abstract void SetObjectsPosition();
}
