using ProjectAirplane.Drawings;
using ProjectAirplane.Entities;

namespace ProjectAirplane;

/// <summary>
/// Форма конфигурации объекта
/// </summary>
public partial class FormAirplaneConfig : Form
{
  /// <summary>
  /// Объект - прорисовка лодки
  /// </summary>
  private DrawingAirplane _airplane;

  /// <summary>
  /// Событие для передачи объекта
  /// </summary>
  private event AirplaneDelegate? AirplaneDelegate;

  /// <summary>
  /// Конструктор
  /// </summary>
  public FormAirplaneConfig()
  {

    InitializeComponent();
    panelRed.MouseDown += Panel_MouseDown;
    panelGreen.MouseDown += Panel_MouseDown;
    panelBlue.MouseDown += Panel_MouseDown;
    panelYellow.MouseDown += Panel_MouseDown;
    panelWhite.MouseDown += Panel_MouseDown;
    panelGray.MouseDown += Panel_MouseDown;
    panelBlack.MouseDown += Panel_MouseDown;
    panelPurple.MouseDown += Panel_MouseDown;

    buttonCancel.Click += (sender, e) => Close();

  }

  /// <summary>
  /// Привязка к событию
  /// </summary>
  /// <param name="airplaneDelegate"></param>
  public void AddEvent(AirplaneDelegate airplaneDelegate)
  {
    AirplaneDelegate += airplaneDelegate;
  }

  /// <summary>
  /// Прорисовка объекта
  /// </summary>
  private void DrawObject()
  {
    Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
    Graphics gr = Graphics.FromImage(bmp);
    _airplane?.SetPictureSize(pictureBoxObject.Width, pictureBoxObject.Height);
    _airplane?.SetPosition(5, 5);
    _airplane?.DrawTransport(gr);
    pictureBoxObject.Image = bmp;
  }

  /// <summary>
  /// Передаем информацию при нажатии на Label
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void LabelObject_MouseDown(object sender, MouseEventArgs e)
  {
    (sender as Label)?.DoDragDrop((sender as Label)?.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
  }

  /// <summary>
  /// Проверка получаемой информации (ее типа на соответствие требуемому)
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void PanelObject_DragEnter(object sender, DragEventArgs e)
  {
    e.Effect = e.Data?.GetDataPresent(DataFormats.Text) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
  }

  /// <summary>
  /// Действия при приеме перетаскиваемой информации
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void PanelObject_DragDrop(object sender, DragEventArgs e)
  {
    switch (e.Data?.GetData(DataFormats.Text)?.ToString())
    {
      case "labelSimpleObject":
        _airplane = new DrawingAirplane((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White);
        break;
      case "labelModifiedObject":
        _airplane = new DrawingMilitaryAirplane((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White,
            Color.Black, checkBoxFirstEngine.Checked, checkBoxSecondEngine.Checked);
        break;
    }
    DrawObject();
  }

  /// <summary>
  /// Передаем информацию принажатии на Panel
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void Panel_MouseDown(object? sender, MouseEventArgs e)
  {
    (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
  }
  /// <summary>
  /// Проверка получаемой информации (ее типа на соответствие требуемому)
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void LabelColor_DragEnter(object sender, DragEventArgs e)
  {
    e.Effect = e.Data?.GetDataPresent(typeof(Color)) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
  }

  /// <summary>
  /// Действия при приеме перетаскиваемой информации
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void LabelColor_DragDrop(object sender, DragEventArgs e)
  {
    if (_airplane == null || _airplane.EntityAirplane == null)
      return;

    ((Label)sender).BackColor = (Color)e.Data.GetData(typeof(Color));

    switch (((Label)sender).Name)
    {
      case "labelBodyColor":
        _airplane.EntityAirplane.ChangeColor((Color)e.Data.GetData(typeof(Color)));
        break;
      case "labelAdditionalColor":
        if (_airplane is DrawingMilitaryAirplane drawningMotorBoat && _airplane.EntityAirplane is EntityMilitaryAirplane entityMotorBoat)
        {
          entityMotorBoat.ChangeAdditionalColor((Color)e.Data?.GetData(typeof(Color)));
        }
        break;
    }

    DrawObject();
  }

  /// <summary>
  /// Передача объекта
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonAdd_Click(object sender, EventArgs e)
  {
    if (_airplane != null)
    {
      AirplaneDelegate?.Invoke(_airplane);
      Close();
    }
  }
}
