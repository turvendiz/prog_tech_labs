using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirplane;

/// <summary>
/// Форма работы с объектом "Самолет"
/// </summary>
public partial class FormAirplane : Form
{
  /// <summary>
  /// Поле-объект для прорисовки объекта
  /// </summary>
  private DrawingAirplane? _drawingAirplane;

  /// <summary>
  /// Конструктор
  public FormAirplane()
  {
    InitializeComponent();
  }

  /// <summary>
  /// Метод прорисовки машины
  /// </summary>
  private void Draw()
  {
    if (_drawingAirplane == null)
    {
      return;
    }
    Bitmap bmp = new(pictureBoxAirplane.Width,
    pictureBoxAirplane.Height);
    Graphics gr = Graphics.FromImage(bmp);
    _drawingAirplane.DrawTransport(gr);
    pictureBoxAirplane.Image = bmp;
  }

  /// <summary>
  /// Обработка нажатия кнопки "Создать"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonCreate_Click(object sender, EventArgs e)
  {
    Random random = new();
    _drawingAirplane = new DrawingAirplane();
    _drawingAirplane.Init(
      random.Next(100, 300),
      random.Next(1000, 3000),
      Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
      Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
      Convert.ToBoolean(random.Next(0, 2)),
      Convert.ToBoolean(random.Next(0, 2)),
      Convert.ToBoolean(random.Next(0, 2))
    );

    _drawingAirplane.SetPictureSize(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
    _drawingAirplane.SetPosition(random.Next(10, 100), random.Next(10, 100));
    Draw();
  }
  /// <summary>
  /// Перемещение объекта по форме (нажатие кнопок навигации)
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonMove_Click(object sender, EventArgs e)
  {
    if (_drawingAirplane == null)
    {
      return;
    }
    string name = ((Button)sender)?.Name ?? string.Empty;
    bool result = false;
    switch (name)
    {
      case "btnUp":
        result =
        _drawingAirplane.MoveTransport(DirectionType.Up);
        break;

      case "btnDown":
        result =
        _drawingAirplane.MoveTransport(DirectionType.Down);
        break;

      case "btnLeft":
        result =
        _drawingAirplane.MoveTransport(DirectionType.Left);
        break;

      case "btnRight":
        result =
        _drawingAirplane.MoveTransport(DirectionType.Right);
        break;
    }
    if (result)
    {
      Draw();
    }
  }
}