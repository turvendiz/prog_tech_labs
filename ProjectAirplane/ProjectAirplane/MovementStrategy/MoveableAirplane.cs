using ProjectAirplane.Drawings;

namespace ProjectAirplane.MovementStrategy;

/// <summary>
/// Класс-реализация IMoveableObjects с использованием DrawingAirplane
/// </summary>
public class MoveableAirplane : IMoveableObjects
{
  /// <summary>
  ///  Поле-объект класса DrawingAirplane или его наследника
  /// </summary>
  private readonly DrawingAirplane? _airplane = null;

  /// <summary>
  /// Конструктор
  /// </summary>
  /// <param name="airplane">Объект класса DrawingAirplane</param>
  public MoveableAirplane(DrawingAirplane airplane)
  {
    _airplane = airplane;
  }

  public ObjectParameters? GetObjectPosition
  {
    get
    {
      if (_airplane == null || _airplane.EntityAirplane == null || !_airplane.GetPosX.HasValue || !_airplane.GetPosY.HasValue)
      {
        return null;
      }
      return new ObjectParameters(_airplane.GetPosX.Value, _airplane.GetPosY.Value, _airplane.GetWidth, _airplane.GetHeight);
    }
  }

  public int GetStep => (int)(_airplane?.EntityAirplane?.Step ?? 0);

  public bool TryMoveObject(MovementDirection direction)
  {
    if (_airplane == null || _airplane.EntityAirplane == null)
    {
      return false;
    }

    return _airplane.MoveTransport(GetDirectionType(direction));
  }

  /// <summary>
  /// Конвертация из MovementDirection в DirectionType
  /// </summary>
  /// <param name="direction">MovementDirection</param>
  /// <returns>DirectionType</returns>
  private static DirectionType GetDirectionType(MovementDirection direction) => direction switch
  {
    MovementDirection.Left => DirectionType.Left,
    MovementDirection.Right => DirectionType.Right,
    MovementDirection.Up => DirectionType.Up,
    MovementDirection.Down => DirectionType.Down,
    _ => DirectionType.Unknow,
  };
}
