using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
  /// Левая координата прорисовки автомобиля
  /// </summary>
  private int? _startPosX;
  /// <summary>
  /// Верхняя кооридната прорисовки автомобиля
  /// </summary>
  private int? _startPosY;
  /// <summary>
  /// Ширина прорисовки автомобиля
  /// </summary>
  private readonly int _drawningCarWidth = 120;
  /// <summary>
  /// Высота прорисовки автомобиля
  /// </summary>
  private readonly int _drawningCarHeight = 120;
  /// <summary>
  /// Инициализация свойств
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес</param>
  /// <param name="bodyColor">Основной цвет</param>
  /// <param name="additionalColor">Дополнительный цвет</param>
  /// <param name="bodyKit">Признак наличия обвеса</param>
  /// <param name="wing">Признак наличия антикрыла</param>
  /// <param name="sportLine">Признак наличия гоночной полосы</param>
  public void Init(int speed, double weight, Color bodyColor, Color
  additionalColor, bool bodyKit, bool wing, bool sportLine)
  {
    EntityAirplane = new EntityAirplane();
    EntityAirplane.Init(speed, weight, bodyColor, additionalColor,
    bodyKit, wing, sportLine);
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
    // TODO проверка, что объект "влезает" в размеры поля
    // если влезает, сохраняем границы и корректируем позицию объекта, если она была уже установлена
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
    if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
    {
      return;
    }
    // TODO если при установке объекта в эти координаты, он будет "выходить" за границы формы
    // то надо изменить координаты, чтобы он оставался в этих границах
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
    if (EntityAirplane == null || !_startPosX.HasValue ||
    !_startPosY.HasValue)
    {
      return false;
    }
    switch (direction)
    {
      //влево
      case DirectionType.Left:
        if (_startPosX.Value - EntityAirplane.Step > -20)
        {
          _startPosX -= (int)EntityAirplane.Step;
        }
        return true;

      //вверх
      case DirectionType.Up:
        if (_startPosY.Value - EntityAirplane.Step > 25)
        {
          _startPosY -= (int)EntityAirplane.Step;
        }
        return true;

      // вправо
      case DirectionType.Right:
        if (_startPosX.Value + EntityAirplane.Step < 910)
        {
          _startPosX += (int)EntityAirplane.Step;
        }
        return true;

      //вниз
      case DirectionType.Down:
        if (_startPosY.Value + EntityAirplane.Step < 525)
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

    // обвесы
    if (EntityAirplane.BodyKit)
    {
      g.DrawRectangle(pen, _startPosX.Value + 65, _startPosY.Value - 14, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 65, _startPosY.Value + 35, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 65, _startPosY.Value - 14, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 65, _startPosY.Value + 35, 5, 4);

    }
    if (EntityAirplane.Wing)
    {
      g.DrawRectangle(pen, _startPosX.Value + 65, _startPosY.Value - 5, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 65, _startPosY.Value + 26, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 65, _startPosY.Value - 5, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 65, _startPosY.Value + 26, 5, 4);
    }


    //границы самолета

    g.DrawRectangle(pen, _startPosX.Value + 20, _startPosY.Value + 4, 70, 15);
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 90, _startPosY.Value + 4),
      new Point(_startPosX.Value + 90, _startPosY.Value + 19),
      new Point(_startPosX.Value + 105, _startPosY.Value + 12)
    });
    g.FillPolygon(new SolidBrush(Color.Black), new Point[] {
      new Point(_startPosX.Value + 90, _startPosY.Value + 4),
      new Point(_startPosX.Value + 90, _startPosY.Value + 19),
      new Point(_startPosX.Value + 105, _startPosY.Value + 12)
    });
    // Нарисовать трапецию левого крыла
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 60, _startPosY.Value - 25),  // Левая верхняя точка
      new Point(_startPosX.Value + 65, _startPosY.Value - 25),  // Правая верхняя точка
      new Point(_startPosX.Value + 65, _startPosY.Value + 4),   // Правая нижняя точка
      new Point(_startPosX.Value + 45, _startPosY.Value + 4)    // Левая нижняя точка
    });
    // Нарисовать трапецию правого крыла
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 60, _startPosY.Value + 49),  // Левая верхняя точка
      new Point(_startPosX.Value + 65, _startPosY.Value + 49),  // Правая верхняя точка
      new Point(_startPosX.Value + 65, _startPosY.Value + 19),  // Правая нижняя точка
      new Point(_startPosX.Value + 45, _startPosY.Value + 19)   // Левая нижняя точка
    });
    // Нарисовать трапецию левого хвоста
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 20, _startPosY.Value - 10),  // Левая верхняя точка
      new Point(_startPosX.Value + 27, _startPosY.Value),  // Правая верхняя точка
      new Point(_startPosX.Value + 27, _startPosY.Value + 4),   // Правая нижняя точка
      new Point(_startPosX.Value + 20, _startPosY.Value + 4)    // Левая нижняя точка
    });
    // Нарисовать трапецию правого хвоста
    g.DrawPolygon(pen, new Point[] {
      new Point(_startPosX.Value + 20, _startPosY.Value + 33),  // Левая верхняя точка
      new Point(_startPosX.Value + 27, _startPosY.Value + 24),  // Правая верхняя точка
      new Point(_startPosX.Value + 27, _startPosY.Value + 19),   // Правая нижняя точка
      new Point(_startPosX.Value + 20, _startPosY.Value + 19)    // Левая нижняя точка
    });

    //Кабина
    Brush br = new SolidBrush(EntityAirplane.BodyColor);
    g.FillRectangle(br, _startPosX.Value + 20, _startPosY.Value + 4, 70, 15);

    g.FillPolygon(br, new Point[] {
      new Point(_startPosX.Value + 60, _startPosY.Value - 25),
      new Point(_startPosX.Value + 65, _startPosY.Value - 25),
      new Point(_startPosX.Value + 65, _startPosY.Value + 4),
      new Point(_startPosX.Value + 45, _startPosY.Value + 4)
    });
    g.FillPolygon(br, new Point[] {
      new Point(_startPosX.Value + 60, _startPosY.Value + 49),
      new Point(_startPosX.Value + 65, _startPosY.Value + 49),
      new Point(_startPosX.Value + 65, _startPosY.Value + 19),
      new Point(_startPosX.Value + 45, _startPosY.Value + 19)
    });
    g.FillPolygon(additionalBrush, new Point[] {
      new Point(_startPosX.Value + 20, _startPosY.Value - 10),
      new Point(_startPosX.Value + 27, _startPosY.Value),
      new Point(_startPosX.Value + 27, _startPosY.Value + 4),
      new Point(_startPosX.Value + 20, _startPosY.Value + 4)
    });
    g.FillPolygon(additionalBrush, new Point[] {
      new Point(_startPosX.Value + 20, _startPosY.Value + 33),
      new Point(_startPosX.Value + 27, _startPosY.Value + 24),
      new Point(_startPosX.Value + 27, _startPosY.Value + 19),
      new Point(_startPosX.Value + 20, _startPosY.Value + 19)
    });
  }
}