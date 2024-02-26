namespace ProjectAirplane
{
  partial class FormAirplaneConfig
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
      groupBoxConfig = new GroupBox();
      groupBoxColors = new GroupBox();
      panelPurple = new Panel();
      panelBlack = new Panel();
      panelGray = new Panel();
      panelWhite = new Panel();
      panelYellow = new Panel();
      panelBlue = new Panel();
      panelGreen = new Panel();
      panelRed = new Panel();
      checkBoxSecondEngine = new CheckBox();
      checkBoxFirstEngine = new CheckBox();
      numericUpDownWeight = new NumericUpDown();
      labelWeight = new Label();
      numericUpDownSpeed = new NumericUpDown();
      labelSpeed = new Label();
      labelModifiedObject = new Label();
      labelSimpleObject = new Label();
      panelObject = new Panel();
      labelAdditionalColor = new Label();
      labelBodyColor = new Label();
      pictureBoxObject = new PictureBox();
      buttonCancel = new Button();
      buttonAdd = new Button();
      groupBoxConfig.SuspendLayout();
      groupBoxColors.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
      panelObject.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
      SuspendLayout();
      // 
      // groupBoxConfig
      // 
      groupBoxConfig.Controls.Add(groupBoxColors);
      groupBoxConfig.Controls.Add(checkBoxSecondEngine);
      groupBoxConfig.Controls.Add(checkBoxFirstEngine);
      groupBoxConfig.Controls.Add(numericUpDownWeight);
      groupBoxConfig.Controls.Add(labelWeight);
      groupBoxConfig.Controls.Add(numericUpDownSpeed);
      groupBoxConfig.Controls.Add(labelSpeed);
      groupBoxConfig.Controls.Add(labelModifiedObject);
      groupBoxConfig.Controls.Add(labelSimpleObject);
      groupBoxConfig.Dock = DockStyle.Left;
      groupBoxConfig.Location = new Point(0, 0);
      groupBoxConfig.Name = "groupBoxConfig";
      groupBoxConfig.Size = new Size(460, 229);
      groupBoxConfig.TabIndex = 1;
      groupBoxConfig.TabStop = false;
      groupBoxConfig.Text = "Параметры";
      // 
      // groupBoxColors
      // 
      groupBoxColors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      groupBoxColors.Controls.Add(panelPurple);
      groupBoxColors.Controls.Add(panelBlack);
      groupBoxColors.Controls.Add(panelGray);
      groupBoxColors.Controls.Add(panelWhite);
      groupBoxColors.Controls.Add(panelYellow);
      groupBoxColors.Controls.Add(panelBlue);
      groupBoxColors.Controls.Add(panelGreen);
      groupBoxColors.Controls.Add(panelRed);
      groupBoxColors.Location = new Point(223, 22);
      groupBoxColors.Name = "groupBoxColors";
      groupBoxColors.Size = new Size(191, 122);
      groupBoxColors.TabIndex = 9;
      groupBoxColors.TabStop = false;
      groupBoxColors.Text = "Цвета";
      // 
      // panelPurple
      // 
      panelPurple.BackColor = Color.Purple;
      panelPurple.Location = new Point(144, 74);
      panelPurple.Name = "panelPurple";
      panelPurple.Size = new Size(40, 40);
      panelPurple.TabIndex = 9;
      // 
      // panelBlack
      // 
      panelBlack.BackColor = Color.Black;
      panelBlack.Location = new Point(98, 74);
      panelBlack.Name = "panelBlack";
      panelBlack.Size = new Size(40, 40);
      panelBlack.TabIndex = 8;
      // 
      // panelGray
      // 
      panelGray.BackColor = Color.Gray;
      panelGray.Location = new Point(52, 74);
      panelGray.Name = "panelGray";
      panelGray.Size = new Size(40, 40);
      panelGray.TabIndex = 7;
      // 
      // panelWhite
      // 
      panelWhite.BackColor = Color.White;
      panelWhite.Location = new Point(6, 74);
      panelWhite.Name = "panelWhite";
      panelWhite.Size = new Size(40, 40);
      panelWhite.TabIndex = 6;
      // 
      // panelYellow
      // 
      panelYellow.BackColor = Color.Yellow;
      panelYellow.Location = new Point(144, 28);
      panelYellow.Name = "panelYellow";
      panelYellow.Size = new Size(40, 40);
      panelYellow.TabIndex = 5;
      // 
      // panelBlue
      // 
      panelBlue.BackColor = Color.Blue;
      panelBlue.Location = new Point(98, 28);
      panelBlue.Name = "panelBlue";
      panelBlue.Size = new Size(40, 40);
      panelBlue.TabIndex = 4;
      // 
      // panelGreen
      // 
      panelGreen.BackColor = Color.Green;
      panelGreen.Location = new Point(52, 28);
      panelGreen.Name = "panelGreen";
      panelGreen.Size = new Size(40, 40);
      panelGreen.TabIndex = 2;
      // 
      // panelRed
      // 
      panelRed.BackColor = Color.Red;
      panelRed.Location = new Point(6, 28);
      panelRed.Name = "panelRed";
      panelRed.Size = new Size(40, 40);
      panelRed.TabIndex = 1;
      // 
      // checkBoxSecondEngine
      // 
      checkBoxSecondEngine.AutoSize = true;
      checkBoxSecondEngine.Location = new Point(6, 143);
      checkBoxSecondEngine.Name = "checkBoxSecondEngine";
      checkBoxSecondEngine.Size = new Size(162, 19);
      checkBoxSecondEngine.TabIndex = 7;
      checkBoxSecondEngine.Text = "Наличие доп двигателей";
      checkBoxSecondEngine.UseVisualStyleBackColor = true;
      // 
      // checkBoxFirstEngine
      // 
      checkBoxFirstEngine.AutoSize = true;
      checkBoxFirstEngine.Location = new Point(6, 118);
      checkBoxFirstEngine.Name = "checkBoxFirstEngine";
      checkBoxFirstEngine.Size = new Size(197, 19);
      checkBoxFirstEngine.TabIndex = 6;
      checkBoxFirstEngine.Text = "Наличие основных двигателей";
      checkBoxFirstEngine.UseVisualStyleBackColor = true;
      // 
      // numericUpDownWeight
      // 
      numericUpDownWeight.Location = new Point(74, 76);
      numericUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
      numericUpDownWeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
      numericUpDownWeight.Name = "numericUpDownWeight";
      numericUpDownWeight.Size = new Size(72, 23);
      numericUpDownWeight.TabIndex = 5;
      numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
      // 
      // labelWeight
      // 
      labelWeight.AutoSize = true;
      labelWeight.Location = new Point(6, 78);
      labelWeight.Name = "labelWeight";
      labelWeight.Size = new Size(29, 15);
      labelWeight.TabIndex = 4;
      labelWeight.Text = "Вес:";
      // 
      // numericUpDownSpeed
      // 
      numericUpDownSpeed.Location = new Point(74, 35);
      numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
      numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
      numericUpDownSpeed.Name = "numericUpDownSpeed";
      numericUpDownSpeed.Size = new Size(72, 23);
      numericUpDownSpeed.TabIndex = 3;
      numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
      // 
      // labelSpeed
      // 
      labelSpeed.AutoSize = true;
      labelSpeed.Location = new Point(6, 37);
      labelSpeed.Name = "labelSpeed";
      labelSpeed.Size = new Size(62, 15);
      labelSpeed.TabIndex = 2;
      labelSpeed.Text = "Скорость:";
      // 
      // labelModifiedObject
      // 
      labelModifiedObject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
      labelModifiedObject.Location = new Point(321, 176);
      labelModifiedObject.Name = "labelModifiedObject";
      labelModifiedObject.Size = new Size(93, 33);
      labelModifiedObject.TabIndex = 1;
      labelModifiedObject.Text = "Продвинутый";
      labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
      labelModifiedObject.MouseDown += LabelObject_MouseDown;
      // 
      // labelSimpleObject
      // 
      labelSimpleObject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
      labelSimpleObject.Location = new Point(223, 176);
      labelSimpleObject.Name = "labelSimpleObject";
      labelSimpleObject.Size = new Size(92, 33);
      labelSimpleObject.TabIndex = 0;
      labelSimpleObject.Text = "Простой";
      labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
      labelSimpleObject.MouseDown += LabelObject_MouseDown;
      // 
      // panelObject
      // 
      panelObject.AllowDrop = true;
      panelObject.Controls.Add(labelAdditionalColor);
      panelObject.Controls.Add(labelBodyColor);
      panelObject.Controls.Add(pictureBoxObject);
      panelObject.Dock = DockStyle.Top;
      panelObject.Location = new Point(460, 0);
      panelObject.Name = "panelObject";
      panelObject.Size = new Size(217, 180);
      panelObject.TabIndex = 5;
      panelObject.DragDrop += PanelObject_DragDrop;
      panelObject.DragEnter += PanelObject_DragEnter;
      // 
      // labelAdditionalColor
      // 
      labelAdditionalColor.AllowDrop = true;
      labelAdditionalColor.AutoSize = true;
      labelAdditionalColor.Location = new Point(137, 9);
      labelAdditionalColor.Name = "labelAdditionalColor";
      labelAdditionalColor.Size = new Size(59, 15);
      labelAdditionalColor.TabIndex = 3;
      labelAdditionalColor.Text = "Доп. цвет";
      labelAdditionalColor.DragDrop += LabelColor_DragDrop;
      labelAdditionalColor.DragEnter += LabelColor_DragEnter;
      // 
      // labelBodyColor
      // 
      labelBodyColor.AllowDrop = true;
      labelBodyColor.AutoSize = true;
      labelBodyColor.BackColor = SystemColors.Control;
      labelBodyColor.Location = new Point(3, 9);
      labelBodyColor.Name = "labelBodyColor";
      labelBodyColor.Size = new Size(81, 15);
      labelBodyColor.TabIndex = 2;
      labelBodyColor.Text = "Базовый цвет";
      labelBodyColor.DragDrop += LabelColor_DragDrop;
      labelBodyColor.DragEnter += LabelColor_DragEnter;
      // 
      // pictureBoxObject
      // 
      pictureBoxObject.Location = new Point(15, 60);
      pictureBoxObject.Name = "pictureBoxObject";
      pictureBoxObject.Size = new Size(184, 102);
      pictureBoxObject.TabIndex = 1;
      pictureBoxObject.TabStop = false;
      // 
      // buttonCancel
      // 
      buttonCancel.Location = new Point(597, 186);
      buttonCancel.Name = "buttonCancel";
      buttonCancel.Size = new Size(75, 23);
      buttonCancel.TabIndex = 7;
      buttonCancel.Text = "Отмена";
      buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAdd
      // 
      buttonAdd.Location = new Point(476, 186);
      buttonAdd.Name = "buttonAdd";
      buttonAdd.Size = new Size(75, 23);
      buttonAdd.TabIndex = 6;
      buttonAdd.Text = "Добавить";
      buttonAdd.UseVisualStyleBackColor = true;
      buttonAdd.Click += buttonAdd_Click;
      // 
      // FormAirplaneConfig
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(677, 229);
      Controls.Add(buttonCancel);
      Controls.Add(buttonAdd);
      Controls.Add(panelObject);
      Controls.Add(groupBoxConfig);
      Name = "FormAirplaneConfig";
      Text = "Создание объекта";
      groupBoxConfig.ResumeLayout(false);
      groupBoxConfig.PerformLayout();
      groupBoxColors.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
      panelObject.ResumeLayout(false);
      panelObject.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxConfig;
    private GroupBox groupBoxColors;
    private Panel panelPurple;
    private Panel panelBlack;
    private Panel panelGray;
    private Panel panelWhite;
    private Panel panelYellow;
    private Panel panelBlue;
    private Panel panelGreen;
    private Panel panelRed;
    private CheckBox checkBoxSecondEngine;
    private CheckBox checkBoxFirstEngine;
    private NumericUpDown numericUpDownWeight;
    private Label labelWeight;
    private NumericUpDown numericUpDownSpeed;
    private Label labelSpeed;
    private Label labelModifiedObject;
    private Label labelSimpleObject;
    private Panel panelObject;
    private Label labelAdditionalColor;
    private Label labelBodyColor;
    private PictureBox pictureBoxObject;
    private Button buttonCancel;
    private Button buttonAdd;
  }
}