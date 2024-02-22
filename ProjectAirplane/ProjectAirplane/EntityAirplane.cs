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
  /// Признак (опция) наличия первой пары двигателей
  /// </summary>
  public bool EngineFirst { get; private set; }

  /// <summary>
  /// Признак (опция) наличия второй пары двигателей
  /// </summary>
  public bool EngineSecond { get; private set; }

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
  /// <param name="engineFirst">Признак наличия первой пары двигателей</param>
  /// <param name="engineSecond">Признак наличия второй пары двигателей</param>
  public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool engineFirst, bool engineSecond)
  {
    Speed = speed;
    Weight = weight;
    BodyColor = bodyColor;
    AdditionalColor = additionalColor;
    EngineFirst = engineFirst;
    EngineSecond = engineSecond;
  }
}