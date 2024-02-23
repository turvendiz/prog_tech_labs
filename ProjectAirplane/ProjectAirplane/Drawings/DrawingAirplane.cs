using ProjectAirplane.Entities;

namespace ProjectAirplane.Drawings;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawingAirplane
{

  /// <summary>
  /// Класс-сущность
  /// </summary>
  public EntityAirplane? EntityAirplane { get; protected set; }

  /// <summary>
  /// Ширина окна
  /// </summary>
  private int? _pictureWidth;

  /// <summary>
  /// Высота окна
  /// </summary>
  private int? _pictureHeight;

  /// <summary>
  /// Левая координата прорисовки самолета
  /// </summary>
  protected int? _startPosX;

  /// <summary>
  /// Верхняя координата прорисовки самолета
  /// </summary>
  protected int? _startPosY;

  /// <summary>
  /// Ширина прорисовки самолета
  /// </summary>
  private readonly int _drawingAirplaneWidth = 85;

  /// <summary>
  /// Высота прорисовки самолета
  /// </summary>
  private readonly int _drawingAirplaneHeight = 74;

  /// <summary>
  /// Координа Х
  /// </summary>
  public int? GetPosX => _startPosX;

  /// <summary>
  /// Координата Y
  /// </summary>
  public int? GetPosY => _startPosY;

  /// <summary>
  /// Ширина объекта
  /// </summary>
  public int GetWidth => _drawingAirplaneWidth;

  /// <summary>
  /// Высота объекта
  /// </summary>
  public int GetHeight => _drawingAirplaneHeight;

  /// <summary>
  /// Пустой онструктор
  /// </summary>
  private DrawingAirplane()
  {
    _pictureWidth = null;
    _pictureHeight = null;
    _startPosX = null;
    _startPosY = null;
  }

  /// <summary>
  /// Конструктор для наследников
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес</param>
  /// <param name="bodyColor">Основной цвет</param>
  public DrawingAirplane(int speed, double weight, Color bodyColor) : this()
  {
    EntityAirplane = new EntityAirplane(speed, weight, bodyColor);
  }

  /// <summary>
  /// Конструктор
  /// </summary>
  /// <param name="drawningAirplaneWidth">Ширина прорисовки самолета</param>
  /// <param name="drawningAirplaneHeight">Высота прорисовки самолета</param>
  protected DrawingAirplane(int drawningAirplaneWidth, int drawningAirplaneHeight) : this()
  {
    _drawingAirplaneWidth = drawningAirplaneWidth;
    _drawingAirplaneHeight = drawningAirplaneHeight;
  }

  /// <summary>
  /// Установка границ поля
  /// </summary>
  /// <param name="width">Ширина поля</param>
  /// <param name="height">Высота поля</param>
  /// <returns>true - границы заданы, false - проверка не пройдена, нельзя разместить объект в этих размерах</returns>
  public bool SetPictureSize(int width, int height)
  {
    _pictureWidth = width;
    _pictureHeight = height;
    return true;
  }

  /// <summary>
  /// Установка позиции
  /// </summary>
  /// <param name="x">Координата X</param>
  /// <param name="y">Координата Y</param>
  public void SetPosition(int? x, int? y)
  {
    if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
    {
      return;
    }
    _startPosX = x;
    _startPosY = y;
  }

  /// <summary>
  /// Изменение направления перемещения
  /// </summary>
  /// <param name="direction">Направление</param>
  /// <returns>true - перемещене выполнено, false - перемещение невозможно</returns>
  public bool MoveTransport(DirectionType direction)
  {
    if (EntityAirplane == null || !_startPosX.HasValue || !_startPosY.HasValue)
    {
      return false;
    }
    switch (direction)
    {
      //влево
      case DirectionType.Left:
        if (_startPosX.Value - EntityAirplane.Step > 0)
        {
          _startPosX -= (int)EntityAirplane.Step;
        }
        return true;

      //вверх
      case DirectionType.Up:
        if (_startPosY.Value - EntityAirplane.Step > 0)
        {
          _startPosY -= (int)EntityAirplane.Step;
        }
        return true;

      // вправо
      case DirectionType.Right:
        if (_startPosX.Value + EntityAirplane.Step < _pictureWidth - _drawingAirplaneWidth)
        {
          _startPosX += (int)EntityAirplane.Step;
        }
        return true;

      //вниз
      case DirectionType.Down:
        if (_startPosY.Value + EntityAirplane.Step < _pictureHeight - _drawingAirplaneHeight)
        {
          _startPosY += (int)EntityAirplane.Step;
        }
        return true;

      default:
        return false;
    }
  }

  /// <summary>
  /// Прорисовка объекта
  /// </summary>
  /// <param name="g"></param>
  public virtual void DrawTransport(Graphics g)
  {
    if (EntityAirplane == null || !_startPosX.HasValue || !_startPosY.HasValue)
    {
      return;
    }
    Pen pen = new(Color.Black);

    //границы самолета
    g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + 29, 70, 15);
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 70, _startPosY.Value + 29),
      new Point(_startPosX.Value + 70, _startPosY.Value + 44),
      new Point(_startPosX.Value + 85, _startPosY.Value + 37)
    });
    g.FillPolygon(new SolidBrush(Color.Black), new Point[] {
       new Point(_startPosX.Value + 70, _startPosY.Value + 29),
       new Point(_startPosX.Value + 70, _startPosY.Value + 44),
       new Point(_startPosX.Value + 85, _startPosY.Value + 37)
     });
    // Нарисовать трапецию левого крыла
    g.DrawPolygon(pen, new Point[] {
       new Point(_startPosX.Value + 40, _startPosY.Value),
       new Point(_startPosX.Value + 45, _startPosY.Value),
       new Point(_startPosX.Value + 45, _startPosY.Value +29),
       new Point(_startPosX.Value + 25, _startPosY.Value + 29)
     });
    // Нарисовать трапецию правого крыла
    g.DrawPolygon(pen, new Point[] {
       new Point(_startPosX.Value + 40, _startPosY.Value + 74),
       new Point(_startPosX.Value + 45, _startPosY.Value + 74),
       new Point(_startPosX.Value + 45, _startPosY.Value + 44),
       new Point(_startPosX.Value + 25, _startPosY.Value + 44)
     });
    // Нарисовать трапецию левого хвоста
    g.DrawPolygon(pen, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 15),
       new Point(_startPosX.Value + 7, _startPosY.Value + 25),
       new Point(_startPosX.Value + 7, _startPosY.Value + 29),
       new Point(_startPosX.Value, _startPosY.Value + 29)
     });
    // Нарисовать трапецию правого хвоста
    g.DrawPolygon(pen, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 58),
       new Point(_startPosX.Value + 7, _startPosY.Value + 49),
       new Point(_startPosX.Value + 7, _startPosY.Value + 44),
       new Point(_startPosX.Value, _startPosY.Value + 44)
     });

    //Кабина
    Brush br = new SolidBrush(EntityAirplane.BodyColor);
    g.FillRectangle(br, _startPosX.Value, _startPosY.Value + 29, 70, 15);

    // Крылья
    g.FillPolygon(br, new Point[] {
       new Point(_startPosX.Value + 40, _startPosY.Value),
       new Point(_startPosX.Value + 45, _startPosY.Value),
       new Point(_startPosX.Value + 45, _startPosY.Value + 29),
       new Point(_startPosX.Value + 25, _startPosY.Value + 29)
     });
    g.FillPolygon(br, new Point[] {
       new Point(_startPosX.Value + 40, _startPosY.Value + 74),
       new Point(_startPosX.Value + 45, _startPosY.Value + 74),
       new Point(_startPosX.Value + 45, _startPosY.Value + 44),
       new Point(_startPosX.Value + 25, _startPosY.Value + 44)
     });
    // хвост
    g.FillPolygon(br, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 15),
       new Point(_startPosX.Value + 7, _startPosY.Value + 25),
       new Point(_startPosX.Value + 7, _startPosY.Value + 29),
       new Point(_startPosX.Value, _startPosY.Value + 29)
     });
    g.FillPolygon(br, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 58),
       new Point(_startPosX.Value + 7, _startPosY.Value + 49),
       new Point(_startPosX.Value + 7, _startPosY.Value + 44),
       new Point(_startPosX.Value, _startPosY.Value + 44)
     });
  }
}
