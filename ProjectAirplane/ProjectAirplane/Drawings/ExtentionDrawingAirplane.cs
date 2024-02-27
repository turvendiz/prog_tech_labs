using ProjectAirplane.Entities;

namespace ProjectAirplane.Drawings;

/// <summary>
/// Расширение для класса EntityCar
/// </summary>
public static class ExtentionDrawningAirplane
{
  /// <summary>
  /// Разделитель для записи информации по объекту в файл
  /// </summary>
  private static readonly string _separatorForObject = ":";

  /// <summary>
  /// Создание объекта из строки
  /// </summary>
  /// <param name="info">Строка с данными для создания объекта</param>
  /// <returns>Объект</returns>
  public static DrawingAirplane? CreateDrawingAirplane(this string info)
  {
    string[] strs = info.Split(_separatorForObject);
    EntityAirplane? airplane = EntityMilitaryAirplane.CreateEntityMilitaryAirplane(strs);
    /*if (aircraft != null)
    {
      return new DrawingMilitaryAirplane(aircraft);
    }

    aircraft = EntityAirplane.CreateEntityAircraft(strs);
    if (aircraft != null)
    {
      return new DrawingAirplane(aircraft);
    }

    return null;*/
DrawingAirplane? drawAirplane = null;

            if (airplane != null)
            {
                EntityMilitaryAirplane? militaryAirplane = (EntityMilitaryAirplane?)airplane;
                drawAirplane = new DrawingMilitaryAirplane(militaryAirplane);
            }
            else
            {
                airplane = EntityAirplane.CreateEntityAirplane(strs);
                if (airplane != null)
                {
                    drawAirplane = new DrawingAirplane(airplane);
                }
            }

            return drawAirplane;
  }

  /// <summary>
  /// Получение данных для сохранения в файл
  /// </summary>
  /// <param name="drawningAircraft">Сохраняемый объект</param>
  /// <returns>Строка с данными по объекту</returns>
  public static string GetDataForSave(this DrawingAirplane drawningAircraft)
  {
    string[]? array = drawningAircraft?.EntityAirplane?.GetStringRepresentation();

    if (array == null)
    {
      return string.Empty;
    }

    return string.Join(_separatorForObject, array);
  }
}