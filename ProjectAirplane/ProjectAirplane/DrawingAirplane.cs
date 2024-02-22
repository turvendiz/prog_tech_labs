namespace ProjectAirplane;

public class DrawingAirplane
{
  /// <summary>
  /// Класс-сущность
  /// </summary>
  public EntityAirplane? EntityAirplane { get; private set; }
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
  private int? _startPosX;
  /// <summary>
  /// Верхняя кооридната прорисовки самолета
  /// </summary>
  private int? _startPosY;
  /// <summary>
  /// Ширина прорисовки самолета
  /// </summary>
  private readonly int _drawningAirplaneWidth = 85;
  /// <summary>
  /// Высота прорисовки самолета
  /// </summary>
  private readonly int _drawningAirplaneHeight = 74;
  /// <summary>
  /// Инициализация свойств
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес</param>
  /// <param name="bodyColor">Основной цвет</param>
  /// <param name="additionalColor">Дополнительный цвет</param>
  /// <param name="engineFirst">Признак наличия первой пары двигателей</param>
  /// <param name="engineSecond">Признак наличия второй пары двигателей</param>
  public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool engineFirst, bool engineSecond)
  {
    EntityAirplane = new EntityAirplane();
    EntityAirplane.Init(speed, weight, bodyColor, additionalColor, engineFirst, engineSecond);
    _pictureWidth = null;
    _pictureHeight = null;
    _startPosX = null;
    _startPosY = null;
  }
  /// <summary>
  /// Установка границ поля
  /// </summary>
  /// <param name="width">Ширина поля</param>
  /// <param name="height">Высота поля</param>
  /// <returns>true - границы заданы, false - проверка не пройдена, нельзя разместить объект в этих размерах</returns>
  public bool SetPictureSize(int width, int height)
  {
    // проверка, что объект "влезает" в размеры поля
    // если влезает, сохраняем границы и корректируем позицию объекта, если она была уже установлена
    if (width < _drawningAirplaneWidth || height < _drawningAirplaneHeight)
      return false;

    _pictureWidth = width;
    _pictureHeight = height;
    return true;
  }
  /// <summary>
  /// Установка позиции
  /// </summary>
  /// <param name="x">Координата X</param>
  /// <param name="y">Координата Y</param>
  public void SetPosition(int x, int y)
  {
    var endx = x + _drawningAirplaneWidth;
    var endy = y + _drawningAirplaneHeight;

    if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
    {
      return;
    }
    // если при установке объекта в эти координаты, он будет "выходить" за границы формы
    // то надо изменить координаты, чтобы он оставался в этих границах
    if (x > _pictureWidth - _drawningAirplaneWidth || 
        y > _pictureHeight - _drawningAirplaneHeight ||
        x < 0 || y < 0)
    {
      x = 0;
      y = 0;
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
        if (_startPosX - EntityAirplane.Step > 0)
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
        if (_startPosX.Value + EntityAirplane.Step < _pictureWidth - _drawningAirplaneWidth)
        {
          _startPosX += (int)EntityAirplane.Step;
        }
        return true;

      //вниз
      case DirectionType.Down:
        if (_startPosY.Value + EntityAirplane.Step < _pictureHeight - _drawningAirplaneHeight)
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
  public void DrawTransport(Graphics g)
  {
    if (EntityAirplane == null || !_startPosX.HasValue || !_startPosY.HasValue)
    {
      return;
    }
    Pen pen = new(Color.Black);
    Brush additionalBrush = new SolidBrush(EntityAirplane.AdditionalColor);

    if (EntityAirplane.EngineFirst)
    {
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 11, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 60, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 11, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 60, 5, 4);

    }
    if (EntityAirplane.EngineSecond)
    {
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 20, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 51, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 20, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 51, 5, 4);
    }


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
    g.FillPolygon(additionalBrush, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 15),
       new Point(_startPosX.Value + 7, _startPosY.Value + 25),
       new Point(_startPosX.Value + 7, _startPosY.Value + 29),
       new Point(_startPosX.Value, _startPosY.Value + 29)
     });
    g.FillPolygon(additionalBrush, new Point[] {
       new Point(_startPosX.Value, _startPosY.Value + 58),
       new Point(_startPosX.Value + 7, _startPosY.Value + 49),
       new Point(_startPosX.Value + 7, _startPosY.Value + 44),
       new Point(_startPosX.Value, _startPosY.Value + 44)
     });
  }
}