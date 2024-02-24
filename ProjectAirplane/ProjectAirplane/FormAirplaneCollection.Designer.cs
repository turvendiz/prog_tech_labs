namespace ProjectAirplane
{
  partial class FormAirplaneCollection
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      groupBoxTools = new GroupBox();
      buttonCreateCompany = new Button();
      panelStorage = new Panel();
      buttonDelCollection = new Button();
      listBoxCollection = new ListBox();
      buttonAddCollection = new Button();
      radioButtonList = new RadioButton();
      radioButtonMassive = new RadioButton();
      textBoxCollectionName = new TextBox();
      labelCollectionName = new Label();
      buttonRefresh = new Button();
      buttonGoToCheck = new Button();
      buttonRemoveAirplane = new Button();
      maskedTextBox = new MaskedTextBox();
      buttonAddMilitaryAirplane = new Button();
      buttonAddAirplane = new Button();
      comboBoxSelectorCompany = new ComboBox();
      pictureBox = new PictureBox();
      panelCompanyTools = new Panel();
      groupBoxTools.SuspendLayout();
      panelStorage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
      panelCompanyTools.SuspendLayout();
      SuspendLayout();
      // 
      // groupBoxTools
      // 
      groupBoxTools.Controls.Add(panelCompanyTools);
      groupBoxTools.Controls.Add(buttonCreateCompany);
      groupBoxTools.Controls.Add(panelStorage);
      groupBoxTools.Controls.Add(comboBoxSelectorCompany);
      groupBoxTools.Dock = DockStyle.Right;
      groupBoxTools.Location = new Point(607, 0);
      groupBoxTools.Name = "groupBoxTools";
      groupBoxTools.Size = new Size(194, 588);
      groupBoxTools.TabIndex = 0;
      groupBoxTools.TabStop = false;
      groupBoxTools.Text = " Инструменты";
      // 
      // buttonCreateCompany
      // 
      buttonCreateCompany.Location = new Point(6, 303);
      buttonCreateCompany.Name = "buttonCreateCompany";
      buttonCreateCompany.Size = new Size(176, 23);
      buttonCreateCompany.TabIndex = 7;
      buttonCreateCompany.Text = "Создание компании";
      buttonCreateCompany.UseVisualStyleBackColor = true;
      buttonCreateCompany.Click += buttonCreateCompany_Click;
      // 
      // panelStorage
      // 
      panelStorage.Controls.Add(buttonDelCollection);
      panelStorage.Controls.Add(listBoxCollection);
      panelStorage.Controls.Add(buttonAddCollection);
      panelStorage.Controls.Add(radioButtonList);
      panelStorage.Controls.Add(radioButtonMassive);
      panelStorage.Controls.Add(textBoxCollectionName);
      panelStorage.Controls.Add(labelCollectionName);
      panelStorage.Dock = DockStyle.Top;
      panelStorage.Location = new Point(3, 19);
      panelStorage.Name = "panelStorage";
      panelStorage.Size = new Size(188, 249);
      panelStorage.TabIndex = 6;
      // 
      // buttonDelCollection
      // 
      buttonDelCollection.Location = new Point(3, 214);
      buttonDelCollection.Name = "buttonDelCollection";
      buttonDelCollection.Size = new Size(176, 23);
      buttonDelCollection.TabIndex = 6;
      buttonDelCollection.Text = "Удалить коллекцию";
      buttonDelCollection.UseVisualStyleBackColor = true;
      buttonDelCollection.Click += buttonDelCollection_Click;
      // 
      // listBoxCollection
      // 
      listBoxCollection.FormattingEnabled = true;
      listBoxCollection.ItemHeight = 15;
      listBoxCollection.Location = new Point(3, 114);
      listBoxCollection.Name = "listBoxCollection";
      listBoxCollection.Size = new Size(176, 94);
      listBoxCollection.TabIndex = 5;
      // 
      // buttonAddCollection
      // 
      buttonAddCollection.Location = new Point(3, 85);
      buttonAddCollection.Name = "buttonAddCollection";
      buttonAddCollection.Size = new Size(176, 23);
      buttonAddCollection.TabIndex = 4;
      buttonAddCollection.Text = "Добавить коллекцию";
      buttonAddCollection.UseVisualStyleBackColor = true;
      buttonAddCollection.Click += buttonAddCollection_Click;
      // 
      // radioButtonList
      // 
      radioButtonList.AutoSize = true;
      radioButtonList.Location = new Point(102, 60);
      radioButtonList.Name = "radioButtonList";
      radioButtonList.Size = new Size(66, 19);
      radioButtonList.TabIndex = 3;
      radioButtonList.TabStop = true;
      radioButtonList.Text = "Список";
      radioButtonList.UseVisualStyleBackColor = true;
      // 
      // radioButtonMassive
      // 
      radioButtonMassive.AutoSize = true;
      radioButtonMassive.Location = new Point(14, 60);
      radioButtonMassive.Name = "radioButtonMassive";
      radioButtonMassive.Size = new Size(67, 19);
      radioButtonMassive.TabIndex = 2;
      radioButtonMassive.TabStop = true;
      radioButtonMassive.Text = "Массив";
      radioButtonMassive.UseVisualStyleBackColor = true;
      // 
      // textBoxCollectionName
      // 
      textBoxCollectionName.Location = new Point(3, 31);
      textBoxCollectionName.Name = "textBoxCollectionName";
      textBoxCollectionName.Size = new Size(176, 23);
      textBoxCollectionName.TabIndex = 1;
      // 
      // labelCollectionName
      // 
      labelCollectionName.AutoSize = true;
      labelCollectionName.Location = new Point(32, 13);
      labelCollectionName.Name = "labelCollectionName";
      labelCollectionName.Size = new Size(125, 15);
      labelCollectionName.TabIndex = 0;
      labelCollectionName.Text = "Название коллекции:";
      // 
      // buttonRefresh
      // 
      buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonRefresh.Location = new Point(6, 207);
      buttonRefresh.Name = "buttonRefresh";
      buttonRefresh.Size = new Size(170, 36);
      buttonRefresh.TabIndex = 5;
      buttonRefresh.Text = "Обновить";
      buttonRefresh.UseVisualStyleBackColor = true;
      buttonRefresh.Click += ButtonRefresh_Click;
      // 
      // buttonGoToCheck
      // 
      buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonGoToCheck.Location = new Point(6, 165);
      buttonGoToCheck.Name = "buttonGoToCheck";
      buttonGoToCheck.Size = new Size(170, 36);
      buttonGoToCheck.TabIndex = 4;
      buttonGoToCheck.Text = "Передать на тесты";
      buttonGoToCheck.UseVisualStyleBackColor = true;
      buttonGoToCheck.Click += ButtonGoToCheck_Click;
      // 
      // buttonRemoveAirplane
      // 
      buttonRemoveAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonRemoveAirplane.Location = new Point(6, 123);
      buttonRemoveAirplane.Name = "buttonRemoveAirplane";
      buttonRemoveAirplane.Size = new Size(170, 36);
      buttonRemoveAirplane.TabIndex = 3;
      buttonRemoveAirplane.Text = " Удалить самолет";
      buttonRemoveAirplane.UseVisualStyleBackColor = true;
      buttonRemoveAirplane.Click += ButtonRemoveAirplane_Click;
      // 
      // maskedTextBox
      // 
      maskedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      maskedTextBox.Location = new Point(6, 94);
      maskedTextBox.Mask = "00";
      maskedTextBox.Name = "maskedTextBox";
      maskedTextBox.Size = new Size(170, 23);
      maskedTextBox.TabIndex = 3;
      maskedTextBox.ValidatingType = typeof(int);
      // 
      // buttonAddMilitaryAirplane
      // 
      buttonAddMilitaryAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonAddMilitaryAirplane.Font = new Font("Segoe UI", 7.9F);
      buttonAddMilitaryAirplane.Location = new Point(6, 52);
      buttonAddMilitaryAirplane.Name = "buttonAddMilitaryAirplane";
      buttonAddMilitaryAirplane.Size = new Size(170, 36);
      buttonAddMilitaryAirplane.TabIndex = 2;
      buttonAddMilitaryAirplane.Text = "Добавление военного самолета";
      buttonAddMilitaryAirplane.UseVisualStyleBackColor = true;
      buttonAddMilitaryAirplane.Click += ButtonAddMilitaryAirplane_Click;
      // 
      // buttonAddAirplane
      // 
      buttonAddAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonAddAirplane.Location = new Point(6, 10);
      buttonAddAirplane.Name = "buttonAddAirplane";
      buttonAddAirplane.Size = new Size(170, 36);
      buttonAddAirplane.TabIndex = 1;
      buttonAddAirplane.Text = "Добавление самолета";
      buttonAddAirplane.UseVisualStyleBackColor = true;
      buttonAddAirplane.Click += ButtonAddAirplane_Click;
      // 
      // comboBoxSelectorCompany
      // 
      comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxSelectorCompany.FormattingEnabled = true;
      comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
      comboBoxSelectorCompany.Location = new Point(6, 274);
      comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
      comboBoxSelectorCompany.Size = new Size(182, 23);
      comboBoxSelectorCompany.TabIndex = 0;
      comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedIndexChanged;
      // 
      // pictureBox
      // 
      pictureBox.Dock = DockStyle.Fill;
      pictureBox.Location = new Point(0, 0);
      pictureBox.Name = "pictureBox";
      pictureBox.Size = new Size(607, 588);
      pictureBox.TabIndex = 1;
      pictureBox.TabStop = false;
      // 
      // panelCompanyTools
      // 
      panelCompanyTools.Controls.Add(buttonAddAirplane);
      panelCompanyTools.Controls.Add(buttonAddMilitaryAirplane);
      panelCompanyTools.Controls.Add(buttonRefresh);
      panelCompanyTools.Controls.Add(maskedTextBox);
      panelCompanyTools.Controls.Add(buttonGoToCheck);
      panelCompanyTools.Controls.Add(buttonRemoveAirplane);
      panelCompanyTools.Dock = DockStyle.Bottom;
      panelCompanyTools.Enabled = false;
      panelCompanyTools.Location = new Point(3, 335);
      panelCompanyTools.Name = "panelCompanyTools";
      panelCompanyTools.Size = new Size(188, 250);
      panelCompanyTools.TabIndex = 8;
      // 
      // FormAirplaneCollection
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(801, 588);
      Controls.Add(pictureBox);
      Controls.Add(groupBoxTools);
      Name = "FormAirplaneCollection";
      Text = "Коллекция самолетов";
      groupBoxTools.ResumeLayout(false);
      panelStorage.ResumeLayout(false);
      panelStorage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
      panelCompanyTools.ResumeLayout(false);
      panelCompanyTools.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxTools;
    private Button buttonAddAirplane;
    private ComboBox comboBoxSelectorCompany;
    private Button buttonAddMilitaryAirplane;
    private Button buttonRemoveAirplane;
    private MaskedTextBox maskedTextBox;
    private PictureBox pictureBox;
    private Button buttonRefresh;
    private Button buttonGoToCheck;
    private Panel panelStorage;
    private ListBox listBoxCollection;
    private Button buttonAddCollection;
    private RadioButton radioButtonList;
    private RadioButton radioButtonMassive;
    private TextBox textBoxCollectionName;
    private Label labelCollectionName;
    private Button buttonCreateCompany;
    private Button buttonDelCollection;
    private Panel panelCompanyTools;
  }
}