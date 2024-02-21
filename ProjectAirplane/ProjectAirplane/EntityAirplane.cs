using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirplane;

/// <summary>
/// Класс-сущность "Самолет"
/// </summary>
public class EntityAirplane
{
  /// <summary>
  /// Скорость
  /// </summary>
  public int Speed { get; private set; }

  /// <summary>
  /// Вес
  /// </summary>
  public double Weight { get; private set; }

  /// <summary>
  /// Основной цвет
  /// </summary>
  public Color BodyColor { get; private set; }

  /// <summary>
  /// Дополнительный цвет (для опциональных элементов)
  /// </summary>
  public Color AdditionalColor { get; private set; }

  /// <summary>
  /// Признак (опция) наличия обвеса
  /// </summary>
  public bool BodyKit { get; private set; }

  /// <summary>
  /// Признак (опция) наличия антикрыла
  /// </summary>
  public bool Wing { get; private set; }

  /// <summary>
  /// Признак (опция) наличия гоночной полосы
  /// </summary>
  public bool SportLine { get; private set; }

  /// <summary>
  /// Шаг перемещения самолета
  /// </summary>
  public double Step => Speed * 100 / Weight;

  /// <summary>
  /// Инициализация полей объекта-класса спортивного автомобиля
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес самолета</param>
  /// <param name="bodyColor">Основной цвет</param>
  /// <param name="additionalColor">Дополнительный цвет</param>
  /// <param name="bodyKit">Признак наличия обвеса</param>
  /// <param name="wing">Признак наличия антикрыла</param>
  /// <param name="sportLine">Признак наличия гоночной полосы</param>
  public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool bodyKit, bool wing, bool sportLine)
  {
    Speed = speed;
    Weight = weight;
    BodyColor = bodyColor;
    AdditionalColor = additionalColor;
    BodyKit = bodyKit;
    Wing = wing;
    SportLine = sportLine;
  }
}