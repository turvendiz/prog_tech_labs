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
      buttonRefresh = new Button();
      buttonGoToCheck = new Button();
      buttonRemoveAirplane = new Button();
      maskedTextBox = new MaskedTextBox();
      buttonAddMilitaryAirplane = new Button();
      buttonAddAirplane = new Button();
      comboBoxSelectorCompany = new ComboBox();
      pictureBox = new PictureBox();
      groupBoxTools.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
      SuspendLayout();
      // 
      // groupBoxTools
      // 
      groupBoxTools.Controls.Add(buttonRefresh);
      groupBoxTools.Controls.Add(buttonGoToCheck);
      groupBoxTools.Controls.Add(buttonRemoveAirplane);
      groupBoxTools.Controls.Add(maskedTextBox);
      groupBoxTools.Controls.Add(buttonAddMilitaryAirplane);
      groupBoxTools.Controls.Add(buttonAddAirplane);
      groupBoxTools.Controls.Add(comboBoxSelectorCompany);
      groupBoxTools.Dock = DockStyle.Right;
      groupBoxTools.Location = new Point(607, 0);
      groupBoxTools.Name = "groupBoxTools";
      groupBoxTools.Size = new Size(194, 588);
      groupBoxTools.TabIndex = 0;
      groupBoxTools.TabStop = false;
      groupBoxTools.Text = " Инструменты";
      // 
      // buttonRefresh
      // 
      buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonRefresh.Location = new Point(6, 450);
      buttonRefresh.Name = "buttonRefresh";
      buttonRefresh.Size = new Size(182, 45);
      buttonRefresh.TabIndex = 5;
      buttonRefresh.Text = "Обновить";
      buttonRefresh.UseVisualStyleBackColor = true;
      buttonRefresh.Click += ButtonRefresh_Click;
      // 
      // buttonGoToCheck
      // 
      buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonGoToCheck.Location = new Point(6, 299);
      buttonGoToCheck.Name = "buttonGoToCheck";
      buttonGoToCheck.Size = new Size(182, 45);
      buttonGoToCheck.TabIndex = 4;
      buttonGoToCheck.Text = "Передать на тесты";
      buttonGoToCheck.UseVisualStyleBackColor = true;
      buttonGoToCheck.Click += ButtonGoToCheck_Click;
      // 
      // buttonRemoveAirplane
      // 
      buttonRemoveAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonRemoveAirplane.Location = new Point(6, 208);
      buttonRemoveAirplane.Name = "buttonRemoveAirplane";
      buttonRemoveAirplane.Size = new Size(182, 45);
      buttonRemoveAirplane.TabIndex = 3;
      buttonRemoveAirplane.Text = " Удалить самолет";
      buttonRemoveAirplane.UseVisualStyleBackColor = true;
      buttonRemoveAirplane.Click += ButtonRemoveAirplane_Click;
      // 
      // maskedTextBox
      // 
      maskedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      maskedTextBox.Location = new Point(6, 179);
      maskedTextBox.Mask = "00";
      maskedTextBox.Name = "maskedTextBox";
      maskedTextBox.Size = new Size(182, 23);
      maskedTextBox.TabIndex = 3;
      maskedTextBox.ValidatingType = typeof(int);
      // 
      // buttonAddMilitaryAirplane
      // 
      buttonAddMilitaryAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonAddMilitaryAirplane.Location = new Point(6, 112);
      buttonAddMilitaryAirplane.Name = "buttonAddMilitaryAirplane";
      buttonAddMilitaryAirplane.Size = new Size(182, 45);
      buttonAddMilitaryAirplane.TabIndex = 2;
      buttonAddMilitaryAirplane.Text = "Добавление военного самолета";
      buttonAddMilitaryAirplane.UseVisualStyleBackColor = true;
      buttonAddMilitaryAirplane.Click += ButtonAddMilitaryAirplane_Click;
      // 
      // buttonAddAirplane
      // 
      buttonAddAirplane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      buttonAddAirplane.Location = new Point(6, 70);
      buttonAddAirplane.Name = "buttonAddAirplane";
      buttonAddAirplane.Size = new Size(182, 36);
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
      comboBoxSelectorCompany.Location = new Point(6, 22);
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
      groupBoxTools.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
  }
}