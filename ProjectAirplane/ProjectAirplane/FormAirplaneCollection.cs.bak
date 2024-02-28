using ProjectAirplane.CollectionGenericObjects;
using ProjectAirplane.Drawings;
using System.Windows.Forms;

namespace ProjectAirplane;

/// <summary>
/// Форма работы с компанией и её коллекцией
/// </summary>
public partial class FormAirplaneCollection : Form
{
  /// <summary>
  /// Хранилише коллекций
  /// </summary>
  private readonly StorageCollection<DrawingAirplane> _storageCollection;

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
    _storageCollection = new();
  }

  /// <summary>
  /// Выбор компании
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
  {
    panelCompanyTools.Enabled = false;
  }

  /// <summary>
  /// Добавление самолета
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ButtonAddAirplane_Click(object sender, EventArgs e)
  {

    FormAirplaneConfig form = new();
    form.AddEvent(SetAirplane);
    form.Show();
  }

  /// <summary>
  /// Добавление автомобиля в коллекцию
  /// </summary>
  /// <param name="boat"></param>
  private void SetAirplane(DrawingAirplane? airplane)
  {
    if (_company == null || airplane == null)
    {
      return;
    }

    if (_company + airplane)
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

  /// <summary>
  /// Добавление коллекции
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonAddCollection_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
    {
      MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    CollectionType collectionType = CollectionType.None;
    if (radioButtonMassive.Checked)
    {
      collectionType = CollectionType.Massive;
    }
    else if (radioButtonList.Checked)
    {
      collectionType = CollectionType.List;
    }

    _storageCollection.AddCollection(textBoxCollectionName.Text, collectionType);
    RefreshListBoxItems();
  }

  /// <summary>
  /// Удаление коллекции
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonDelCollection_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
    {
      MessageBox.Show("Коллекция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }
    if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      return;
    }
    _storageCollection.DelCollection(textBoxCollectionName.Text);
    //MessageBox.Show("Объект удален");
    RefreshListBoxItems();
  }

  /// <summary>
  /// Обновление списка в listBoxCollection
  /// </summary>
  private void RefreshListBoxItems()
  {
    listBoxCollection.Items.Clear();
    for (int i = 0; i < _storageCollection.Keys?.Count; ++i)
    {
      string? colName = _storageCollection.Keys?[i];
      if (!string.IsNullOrEmpty(colName))
      {
        listBoxCollection.Items.Add(colName);
      }
    }

  }

  /// <summary>
  /// Создание компании
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void buttonCreateCompany_Click(object sender, EventArgs e)
  {
    if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
    {
      MessageBox.Show("Коллекция не выбрана");
      return;
    }

    ICollectionGenericObjects<DrawingAirplane>? collection = _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty];
    if (collection == null)
    {
      MessageBox.Show("Коллекция не проинициализирована");
      return;
    }

    switch (comboBoxSelectorCompany.Text)
    {
      case "Хранилище":
        _company = new AirplaneSharingService(pictureBox.Width, pictureBox.Height, collection);
        break;
    }

    panelCompanyTools.Enabled = true;
    RefreshListBoxItems();
  }

  /// <summary>
  /// Обработка нажатия на "Сохранение"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
  {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_storageCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
  }

  /// <summary>
  /// Обработка нажатия на "Загрузка"
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
  {
if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_storageCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузка прошла успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListBoxItems();
                }
                else
                {
                    MessageBox.Show("Не загрузилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshListBoxItems();
  }
}
