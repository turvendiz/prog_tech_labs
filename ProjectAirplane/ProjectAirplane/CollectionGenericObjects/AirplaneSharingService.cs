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

  protected override void DrawBackground(Graphics g)
  {
    Pen pen = new Pen(Color.Black, 1);
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
    }
  }

  protected override void SetObjectsPosition()
  {
    int x = (_placeSizeWidth - 85) / 2;
    int y = (_placeSizeHeight - 50) / 2;
    int objMove = _placeSizeHeight * 3 / 2;
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
        x = (_placeSizeWidth - 85) / 2;
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

    }
  }
}