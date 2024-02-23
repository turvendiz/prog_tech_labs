using ProjectAirplane.Drawings;

namespace ProjectAirplane.CollectionGenericObjects;

/// <summary>
/// Реализация абстрактной компании - каршеринг 
/// </summary>
public class AirplaneSharingService : AbstractCompany
{
  /// <summary>
	/// Конструктор
	/// </summary>
	/// <param name="picWidth"></param>
	/// <param name="picHeight"></param>
	/// <param name="collection"></param>
	public AirplaneSharingService(int picWidth, int picHeight, ICollectionGenericObjects<DrawingAirplane> collection) : base(picWidth, picHeight, collection)
  {
  }

  private int? _startPosX;
  private int? _startPosY;
  private int? ObjPositionX;
  private int? ObjPositionY;

  private void DrawPlace(Graphics g)
  {
    Pen pen = new(Color.Black);
    g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, _placeSizeWidth, _placeSizeHeight);
  }

  protected override void DrawBackground(Graphics g)
  {
    _startPosX = 0;
    _startPosY = 0;
    for (int x = 0; x <= _pictureWidth; x += _placeSizeWidth)
    {
      if ((_pictureWidth - _placeSizeWidth) > _startPosX)
      {
        for (int y = 0; y <= _pictureHeight; y += _placeSizeHeight)
        {
          if ((_pictureHeight - _placeSizeHeight) > _startPosY)
          {
            DrawPlace(g);
            _startPosY += _placeSizeHeight;
          }
        }
        _startPosX += _placeSizeWidth;
        _startPosY = 0;
      }
    }
  }

  protected override void SetObjectsPosition()
  {
    _startPosX = 0;
    _startPosY = 0;
    int i = 0;

    for (int x = 0; x <= _pictureWidth; x = x + _placeSizeWidth)
    {
      if ((_pictureWidth - _placeSizeWidth) > _startPosX)
      {
        ObjPositionX = _startPosX;

        for (int y = 0; y <= _pictureHeight; y = y + _placeSizeHeight)
        {
          if ((_pictureHeight - _placeSizeHeight) > _startPosY)
          {
            ObjPositionY = _startPosY;
            if (i < (_collection?.Count))
            {
              DrawingAirplane obj = _collection.Get(i);

              if (obj != null)
              {
                obj.SetPictureSize(_pictureWidth, _pictureHeight);
                obj.SetPosition(ObjPositionX, ObjPositionY);

              }
              i++;
            }

            _startPosY = _startPosY + _placeSizeHeight;


          }
        }
        _startPosX = _startPosX + _placeSizeWidth;

        _startPosY = 0;
      }
    }
  }
}