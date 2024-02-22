namespace ProjectAirplane.Entities;

/// <summary>
/// Класс-сущность "Самолет"
/// </summary>
public class EntityMilitaryAirplane : EntityAirplane
{
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
  /// Инициализация полей объекта-класса военного самолета
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес самолета</param>
  /// <param name="bodyColor">Основной цвет</param>
  /// <param name="additionalColor">Дополнительный цвет</param>
  /// <param name="engineFirst">Признак наличия первой пары двигателей</param>
  /// <param name="engineSecond">Признак наличия второй пары двигателей</param>
  public EntityMilitaryAirplane(int speed, double weight, Color bodyColor, Color additionalColor, bool engineFirst, bool engineSecond) : base(speed, weight, bodyColor)
  {
    AdditionalColor = additionalColor;
    EngineFirst = engineFirst;
    EngineSecond = engineSecond;
  }
}