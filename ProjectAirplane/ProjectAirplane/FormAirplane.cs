﻿using ProjectAirplane.Drawings;
using ProjectAirplane.MovementStrategy;

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
  /// Стратегия перемещения
  /// </summary>
  private AbstractStrategy? _strategy;

  /// <summary>
  /// Получение объекта 
  /// </summary>
  public DrawingAirplane SetAirplane
  {
    set
    {
      _drawingAirplane = value;
      _drawingAirplane.SetPictureSize(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
      comboBoxStrategy.Enabled = true;
      _strategy = null;
      Draw();
    }
  }

  /// <summary>
  /// Конструктор формы
  /// </summary>
  public FormAirplane()
  {
    InitializeComponent();
    _strategy = null;
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
        result = _drawingAirplane.MoveTransport(DirectionType.Up);
        break;

      case "btnDown":
        result = _drawingAirplane.MoveTransport(DirectionType.Down);
        break;

      case "btnLeft":
        result = _drawingAirplane.MoveTransport(DirectionType.Left);
        break;

      case "btnRight":
        result = _drawingAirplane.MoveTransport(DirectionType.Right);
        break;
    }
    if (result)
    {
      Draw();
    }
  }

  /// <summary>
  /// Обработка нажатия кнопки "Шаг"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonStrategyStep_Click(object sender, EventArgs e)
  {
    if (_drawingAirplane == null)
    {
      return;
    }

    if (comboBoxStrategy.Enabled)
    {
      _strategy = comboBoxStrategy.SelectedIndex switch
      {
        0 => new MoveToCenter(),
        1 => new MoveToBorder(),
        _ => null,
      };
      if (_strategy == null) { return; }

      _strategy.SetData(new MoveableAirplane(_drawingAirplane), pictureBoxAirplane.Width, pictureBoxAirplane.Height);
    }

    if (_strategy == null) { return; }

    comboBoxStrategy.Enabled = false;
    _strategy.MakeStep();
    Draw();

    if (_strategy.GetStatus() == StrategyStatus.Finish)
    {
      comboBoxStrategy.Enabled = true;
      _strategy = null;
    }
  }
}