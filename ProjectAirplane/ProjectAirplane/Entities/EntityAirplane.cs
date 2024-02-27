namespace ProjectAirplane.Entities;

/// <summary>
/// Базовый класс сущность Самолет
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
  /// Шаг перемещения самолета
  /// </summary>
  public double Step => Speed * 100 / Weight;

  /// <summary>
  /// Конструктор сущности
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес самолета</param>
  /// <param name="bodyColor">Основной цвет</param>
  public EntityAirplane(int speed, double weight, Color bodyColor)
  {
    Speed = speed;
    Weight = weight;
    BodyColor = bodyColor;
  }

  /// <summary>
  /// Новый основной цвет
  /// </summary>
  /// <param name="color"></param>
  public void ChangeColor(Color color)
  {
    BodyColor = color;
  }

  /// <summary>
  /// Получение строк со значениями свойств объекта класса-сущности
  /// </summary>
  /// <returns></returns>
  public virtual string[] GetStringRepresentation()
  {
    return new[] { nameof(EntityAirplane), Speed.ToString(), Weight.ToString(), BodyColor.Name };
  }

  /// <summary>
  /// Создание объекта из массива строк
  /// </summary>
  /// <param name="strs"></param>
  /// <returns></returns>
  public static EntityAirplane? CreateEntityAirplane(string[] strs)
  {
    if (strs.Length != 4 || strs[0] != nameof(EntityAirplane))
    {
      return null;
    }

    return new EntityAirplane(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
  }
}

