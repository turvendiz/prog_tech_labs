using ProjectAirplane.Entities;

namespace ProjectAirplane.Drawings;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawingMilitaryAirplane : DrawingAirplane
{
  /// <summary>
  /// Конструктор
  /// </summary>
  /// <param name="additionalColor">Дополнительный цвет</param>
  /// <param name="engineFirst">Признак наличия первой пары двигателей</param>
  /// <param name="engineSecond">Признак наличия второй пары двигателей</param>
  public DrawingMilitaryAirplane(int speed, double weight, Color bodyColor, Color additionalColor, bool engineFirst, bool engineSecond) : base(90,80)//85, 74)
  {
    EntityAirplane = new EntityMilitaryAirplane(speed, weight, bodyColor, additionalColor, engineFirst, engineSecond);
  }

public DrawingMilitaryAirplane(EntityMilitaryAirplane? entityMilitaryAirplane) : base(entityMilitaryAirplane)
        {
        }
  public override void DrawTransport(Graphics g)
  {
    if (EntityAirplane == null || EntityAirplane is not EntityMilitaryAirplane militaryAirplane || !_startPosX.HasValue || !_startPosY.HasValue)
    {
      return;
    }

    Pen pen = new(Color.Black);
    Brush additionalBrush = new SolidBrush(militaryAirplane.AdditionalColor);

    // Обвесы
    if (militaryAirplane.EngineFirst)
    {
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 11, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 60, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 11, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 60, 5, 4);

    }
    if (militaryAirplane.EngineSecond)
    {
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 20, 5, 4);
      g.DrawRectangle(pen, _startPosX.Value + 45, _startPosY.Value + 51, 5, 4);

      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 20, 5, 4);
      g.FillRectangle(additionalBrush, _startPosX.Value + 45, _startPosY.Value + 51, 5, 4);
    }

    base.DrawTransport(g);
  }
}