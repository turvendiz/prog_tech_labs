using ProjectAirplane.CollectionGenericObjects;
using ProjectAirplane.Drawings;

namespace ProjectAirplane;

/// <summary>
/// Форма работы с компанией и её коллекцией
/// </summary>
public partial class FormAirplaneCollection : Form
{
  /// <summary>
  /// Компания
  /// </summary>
  private AbstractCompany? _company = null;


  /// <summary>
  /// Конструктор
  /// </summary>
  public FormAirplaneCollection()
  {
    InitializeComponent();
  }

  /// <summary>
  /// Выбор компании
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
  {
    switch (comboBoxSelectorCompany.Text)
    {
      case "Хранилище":
        _company = new AirplaneSharingService(pictureBox.Width, pictureBox.Height, new MassiveGenericObjects<DrawingAirplane>());
        break;
    }
  }

  /// <summary>
  /// Добавление обычного самолета
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonAddAirplane_Click(object sender, EventArgs e) => CreateObj(nameof(DrawingAirplane));

  /// <summary>
  /// Добавление военного самолета
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonAddMilitaryAirplane_Click(object sender, EventArgs e) => CreateObj(nameof(DrawingMilitaryAirplane));

  /// <summary>
  /// Создание объекта класса-перемещения
  /// </summary>
  /// <param name="type">Тип создаваемого объекта</param>
  private void CreateObj(string type)
  {
    if (_company == null)
    {
      return;
    }
    Random rnd = new();
    DrawingAirplane drawingAirplane;
    switch (type)
    {
      case nameof(DrawingAirplane):
        drawingAirplane = new DrawingAirplane(speed: rnd.Next(100, 300), weight: rnd.Next(1000, 3000), bodyColor: GetColor(rnd));

        break;

      case nameof(DrawingMilitaryAirplane):
        drawingAirplane = new DrawingMilitaryAirplane(
          speed: rnd.Next(100, 300),
          weight: rnd.Next(1000, 3000),
          bodyColor: /*GetColor(rnd),*/Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
          additionalColor: /*GetColor(rnd),*/Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
          engineFirst: Convert.ToBoolean(rnd.Next(0, 2)),
          engineSecond: Convert.ToBoolean(rnd.Next(0, 2)));
        break;
      default:
        return;
    }
    if (_company + drawingAirplane)
    {
      MessageBox.Show("Объект добавлен");
      pictureBox.Image = _company.Show();
    }
    else
    {
      MessageBox.Show("Не удалось добавить объект");
    }
  }

  /// <summary>
  /// Получение цвета
  /// </summary>
  /// <param name="random">Генератор случайных чисел</param>
  /// <returns></returns>
  private static Color GetColor(Random random)
  {
    Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
    ColorDialog dialog = new();
    if (dialog.ShowDialog() == DialogResult.OK)
    {
      color = dialog.Color;
    }
    return color;
  }

  /// <summary>
  /// Удаление самолета
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonRemoveAirplane_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(maskedTextBox.Text) || _company == null)
    {
      return;
    }

    if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      return;
    }

    int pos = Convert.ToInt32(maskedTextBox.Text);
    if (_company - pos)
    {
      MessageBox.Show("Объект удален");
      pictureBox.Image = _company.Show();
    }
    else
    {
      MessageBox.Show("Не удалось удалить объект");
    }
  }

  /// <summary>
  /// Передать на тесты
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonGoToCheck_Click(object sender, EventArgs e)
  {
    if (_company == null)
    {
      return;
    }
    DrawingAirplane? airplane = null;
    int counter = 100;
    while (airplane == null)
    {
      airplane = _company.GetRandomObject();
      counter--;
      if (counter <= 0)
      {
        break;
      }
    }

    if (airplane == null) { return; }

    FormAirplane form = new()
    {
      SetAirplane = airplane
    };
    form.ShowDialog();

  }

  /// <summary>
  /// Обновление
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonRefresh_Click(object sender, EventArgs e)
  {
    if (_company == null)
    {
      return;
    }
    pictureBox.Image = _company.Show();
  }
}
