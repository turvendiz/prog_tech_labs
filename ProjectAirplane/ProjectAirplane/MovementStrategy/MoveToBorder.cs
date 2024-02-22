namespace ProjectAirplane.MovementStrategy;

/// <summary>
/// Стратегия перемещения объекта в правый-нижний угол экрана
/// </summary>
public class MoveToBorder : AbstractStrategy
{
  protected override bool IsTargetDestination()
  {
    ObjectParameters? objParams = GetObjectParameters;
    if (objParams == null)
    {
      return false;
    }

    return objParams.RightBorder <= FieldWidth && objParams.RightBorder + GetStep() >= FieldWidth &&
            objParams.DownBorder <= FieldHeight && objParams.DownBorder + GetStep() >= FieldHeight;
  }

  protected override void MoveToTarget()
  {
    ObjectParameters? objParams = GetObjectParameters;
    if (objParams == null)
    {
      return;
    }

    int diffX = objParams.RightBorder - FieldWidth;
    if (Math.Abs(diffX) > GetStep())
    {
      if (diffX > 0)
      {
        MoveLeft();
      }
      else
      {
        MoveRight();
      }
    }

    int diffY = objParams.DownBorder - FieldHeight;
    if (Math.Abs(diffY) > GetStep())
    {
      if (diffY > 0)
      {
        MoveUp();
      }
      else
      {
        MoveDown();
      }
    }
  }
}
