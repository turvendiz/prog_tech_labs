using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectAirplane.Drawings;

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
    Bitmap bmp = new(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
    Graphics gr = Graphics.FromImage(bmp);
    _drawingAirplane.DrawTransport(gr);
    pictureBoxAirplane.Image = bmp;
  }

  /// <summary>
  /// Создание объекта класса-перемещения
  /// </summary>
  /// <param name="type">Тип создаваемого объекта</param>
  private void CreateObject(string type)
  {
    Random random = new();
    switch (type)
    {
      case nameof(DrawingAirplane):
        _drawingAirplane = new DrawingAirplane(
          speed: random.Next(100, 300),
          weight: random.Next(1000, 3000),
          bodyColor: Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
        break;
      case nameof(DrawingMilitaryAirplane):
        _drawingAirplane = new DrawingMilitaryAirplane(
          speed: random.Next(100, 300),
          weight: random.Next(1000, 3000),
          bodyColor: Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
          additionalColor: Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
          engineFirst: Convert.ToBoolean(random.Next(0, 2)),
          engineSecond: Convert.ToBoolean(random.Next(0, 2)));
        break;
      default:
        return;
    }
    _drawingAirplane.SetPictureSize(pictureBoxAirplane.Width,pictureBoxAirplane.Height);
    _drawingAirplane.SetPosition(random.Next(10, 100), random.Next(10, 100));
    //_strategy = null;
    //comboBoxStrategy.Enabled = true;
    Draw();
  }

  /// <summary>
  /// Обработка нажатия кнопки "Создать военный самолет"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonCreateMilitaryAirplane_Click(object sender, EventArgs e) => CreateObject(nameof(DrawingMilitaryAirplane));

  /// <summary>
  /// Обработка нажатия кнопки "Создать самолет"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonCreateAirplane_Click(object sender, EventArgs e) => CreateObject(nameof(DrawingAirplane));

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