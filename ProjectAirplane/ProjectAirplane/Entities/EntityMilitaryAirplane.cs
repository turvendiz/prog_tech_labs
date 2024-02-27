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

  /// <summary>
  /// Новый дополнительный цвет
  /// </summary>
  /// <param name="color"></param>
  public void ChangeAdditionalColor(Color color)
  {
    AdditionalColor = color;
  }

  /// <summary>
  /// Получение строк со значениями свойств объекта класса-сущности
  /// </summary>
  /// <returns></returns>
  public override string[] GetStringRepresentation()
  {
    //return new[] { nameof(EntityAirplane), Speed.ToString(), Weight.ToString(), BodyColor.Name };

    return new[] { nameof(EntityMilitaryAirplane), Speed.ToString(), Weight.ToString(), BodyColor.Name, AdditionalColor.Name,
                EngineFirst.ToString(), EngineSecond.ToString()};
  }

  /// <summary>
  /// Создание объекта из массива строк
  /// </summary>
  /// <param name="strs"></param>
  /// <returns></returns>
  public static EntityMilitaryAirplane? CreateEntityMilitaryAirplane(string[] strs)
  {
    if (strs.Length != 7 || strs[0] != nameof(EntityMilitaryAirplane))
    {
      return null;
    }
    return new EntityMilitaryAirplane(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]),
        Color.FromName(strs[4]), Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]));
  }
}

