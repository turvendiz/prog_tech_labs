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

  /*private void DrawPosition(Graphics g)
  {
    Pen pen = new(Color.Black);
    g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, 2, 2);
  }*/

  protected override void DrawBackground(Graphics g)
  {

    /*Pen pen = new Pen(Color.Black, 5);
    int fHeight = _pictureHeight / _placeSizeHeight;
    int fWidth = _pictureWidth / _placeSizeWidth;

    for (int i = 0; i < fHeight - 1; i++)
    {
      for (int j = 0; j < fWidth + 1; j++)
      {
        int startY = i * _placeSizeHeight * 3 / 2;
        int endY = (i + 1) * (_placeSizeHeight * 3 / 2);

        g.DrawLine(pen, j * _placeSizeWidth, startY + _placeSizeHeight / 3, j * _placeSizeWidth, endY - _placeSizeHeight / 3);
      }

      int bottomY = (i + 1) * (_placeSizeHeight * 3 / 2);
      g.DrawLine(pen, 0, bottomY - _placeSizeHeight / 3, _pictureWidth / _placeSizeWidth * _placeSizeWidth, bottomY - _placeSizeHeight / 3);
    }*/

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
            /*for (int i = 0; i < (_collection?.Count ?? 0); ++i)
            {
                DrawningPlatforma position = _collection.Get(i);
                if (position != null)
                {
                    position.SetPictureSize(_pictureWidth, _pictureHeight);
                    position.SetPosition(ObjPositionX, ObjPositionY);

                }

            }*/
            //DrawPosition(g);
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

    /* int x = 0;//_placeSizeWidth;
     int y = 0;// _placeSizeHeight;
     int objMove = _placeSizeHeight;
     int rowSum = _pictureHeight / _placeSizeHeight;
     int rowCount = rowSum;
     int massX = _placeSizeWidth / _pictureWidth * _pictureWidth;
     int massY = _placeSizeHeight / _pictureHeight * _pictureHeight;

     for (int i = 0; i < (_collection?.Count ?? 0); i++)

     {
       DrawingAirplane? obj = _collection?.Get(i);


       if (obj == null)
       {
         x += _placeSizeWidth;
         continue;
       }

       obj.SetPictureSize(massX, massY);

       if (i > 0)
       {
         x += _placeSizeWidth;
       }

       if (x >= _pictureWidth - _placeSizeWidth)
       {
         x = 0;
         y += objMove;
         Console.WriteLine(rowSum);
         rowCount--;

         if (rowCount < 2)
         {
           Console.WriteLine("Все места заняты");
           break;
         }
       }

       obj.SetPosition(x, y);

     }*/

    /*_startPosX = 5;
    _startPosY = 5;
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
                obj.SetPosition(Convert.ToInt32(ObjPositionX), Convert.ToInt32(ObjPositionY));

              }
              i++;
            }

            _startPosY = _startPosY + _placeSizeHeight;


          }
        }
        _startPosX = _startPosX + _placeSizeWidth;

        _startPosY = 5;
      }
    }*/
  }
}