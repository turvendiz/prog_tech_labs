namespace ProjectAirplane
{
  partial class FormAirplane
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
      pictureBoxAirplane = new PictureBox();
      buttonCreateMilitaryAirplane = new Button();
      btnUp = new Button();
      btnRight = new Button();
      btnLeft = new Button();
      btnDown = new Button();
      buttonCreateAirplane = new Button();
      comboBoxStrategy = new ComboBox();
      buttonStrategyStep = new Button();
      ((System.ComponentModel.ISupportInitialize)pictureBoxAirplane).BeginInit();
      SuspendLayout();
      // 
      // pictureBoxAirplane
      // 
      pictureBoxAirplane.Dock = DockStyle.Fill;
      pictureBoxAirplane.Location = new Point(0, 0);
      pictureBoxAirplane.Name = "pictureBoxAirplane";
      pictureBoxAirplane.Size = new Size(909, 643);
      pictureBoxAirplane.TabIndex = 0;
      pictureBoxAirplane.TabStop = false;
      // 
      // buttonCreateMilitaryAirplane
      // 
      buttonCreateMilitaryAirplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      buttonCreateMilitaryAirplane.Location = new Point(12, 608);
      buttonCreateMilitaryAirplane.Name = "buttonCreateMilitaryAirplane";
      buttonCreateMilitaryAirplane.Size = new Size(181, 23);
      buttonCreateMilitaryAirplane.TabIndex = 1;
      buttonCreateMilitaryAirplane.Text = "Создать военный самолет";
      buttonCreateMilitaryAirplane.UseVisualStyleBackColor = true;
      buttonCreateMilitaryAirplane.Click += buttonCreateMilitaryAirplane_Click;
      // 
      // btnUp
      // 
      btnUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnUp.BackgroundImage = Properties.Resources.UP;
      btnUp.BackgroundImageLayout = ImageLayout.Stretch;
      btnUp.Location = new Point(811, 545);
      btnUp.Name = "btnUp";
      btnUp.Size = new Size(40, 40);
      btnUp.TabIndex = 2;
      btnUp.UseVisualStyleBackColor = true;
      btnUp.Click += ButtonMove_Click;
      // 
      // btnRight
      // 
      btnRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnRight.BackgroundImage = Properties.Resources.RIGHT;
      btnRight.BackgroundImageLayout = ImageLayout.Stretch;
      btnRight.Location = new Point(857, 591);
      btnRight.Name = "btnRight";
      btnRight.Size = new Size(40, 40);
      btnRight.TabIndex = 3;
      btnRight.UseVisualStyleBackColor = true;
      btnRight.Click += ButtonMove_Click;
      // 
      // btnLeft
      // 
      btnLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnLeft.BackgroundImage = Properties.Resources.LEFT;
      btnLeft.BackgroundImageLayout = ImageLayout.Stretch;
      btnLeft.Location = new Point(765, 591);
      btnLeft.Name = "btnLeft";
      btnLeft.Size = new Size(40, 40);
      btnLeft.TabIndex = 4;
      btnLeft.UseVisualStyleBackColor = true;
      btnLeft.Click += ButtonMove_Click;
      // 
      // btnDown
      // 
      btnDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnDown.BackgroundImage = Properties.Resources.DOWN;
      btnDown.BackgroundImageLayout = ImageLayout.Stretch;
      btnDown.Location = new Point(811, 591);
      btnDown.Name = "btnDown";
      btnDown.Size = new Size(40, 40);
      btnDown.TabIndex = 5;
      btnDown.UseVisualStyleBackColor = true;
      btnDown.Click += ButtonMove_Click;
      // 
      // buttonCreateAirplane
      // 
      buttonCreateAirplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      buttonCreateAirplane.Location = new Point(199, 608);
      buttonCreateAirplane.Name = "buttonCreateAirplane";
      buttonCreateAirplane.Size = new Size(181, 23);
      buttonCreateAirplane.TabIndex = 6;
      buttonCreateAirplane.Text = "Создать самолет";
      buttonCreateAirplane.UseVisualStyleBackColor = true;
      buttonCreateAirplane.Click += buttonCreateAirplane_Click;
      // 
      // comboBoxStrategy
      // 
      comboBoxStrategy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      comboBoxStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBoxStrategy.FormattingEnabled = true;
      comboBoxStrategy.Items.AddRange(new object[] { "К центру", "К краю" });
      comboBoxStrategy.Location = new Point(776, 12);
      comboBoxStrategy.Name = "comboBoxStrategy";
      comboBoxStrategy.Size = new Size(121, 23);
      comboBoxStrategy.TabIndex = 7;
      // 
      // buttonStrategyStep
      // 
      buttonStrategyStep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      buttonStrategyStep.Location = new Point(822, 41);
      buttonStrategyStep.Name = "buttonStrategyStep";
      buttonStrategyStep.Size = new Size(75, 23);
      buttonStrategyStep.TabIndex = 8;
      buttonStrategyStep.Text = "Шаг";
      buttonStrategyStep.UseVisualStyleBackColor = true;
      buttonStrategyStep.Click += buttonStrategyStep_Click;
      // 
      // FormAirplane
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(909, 643);
      Controls.Add(buttonStrategyStep);
      Controls.Add(comboBoxStrategy);
      Controls.Add(buttonCreateAirplane);
      Controls.Add(btnDown);
      Controls.Add(btnLeft);
      Controls.Add(btnRight);
      Controls.Add(btnUp);
      Controls.Add(buttonCreateMilitaryAirplane);
      Controls.Add(pictureBoxAirplane);
      Name = "FormAirplane";
      Text = "Самолёт";
      ((System.ComponentModel.ISupportInitialize)pictureBoxAirplane).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBoxAirplane;
    private Button buttonCreateMilitaryAirplane;
    private Button btnUp;
    private Button btnRight;
    private Button btnLeft;
    private Button btnDown;
    private Button buttonCreateAirplane;
    private ComboBox comboBoxStrategy;
    private Button buttonStrategyStep;
  }
}