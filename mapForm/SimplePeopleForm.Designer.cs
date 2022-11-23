namespace PlagueModel_Cs
{
    partial class SimplePeopleForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SickButton = new System.Windows.Forms.RadioButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.textBoxIncPeriod = new System.Windows.Forms.TextBox();
            this.HealthyButton = new System.Windows.Forms.RadioButton();
            this.textBoxSpeedY = new System.Windows.Forms.TextBox();
            this.textBoxSpeedX = new System.Windows.Forms.TextBox();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.MainPanel.Controls.Add(this.SickButton);
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.textBoxIncPeriod);
            this.MainPanel.Controls.Add(this.HealthyButton);
            this.MainPanel.Controls.Add(this.textBoxSpeedY);
            this.MainPanel.Controls.Add(this.textBoxSpeedX);
            this.MainPanel.Controls.Add(this.textBoxCoordX);
            this.MainPanel.Controls.Add(this.textBoxCoordY);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.NextButton);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(499, 679);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // SickButton
            // 
            this.SickButton.AutoSize = true;
            this.SickButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SickButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SickButton.Location = new System.Drawing.Point(49, 381);
            this.SickButton.Name = "SickButton";
            this.SickButton.Size = new System.Drawing.Size(153, 46);
            this.SickButton.TabIndex = 25;
            this.SickButton.TabStop = true;
            this.SickButton.Text = "Болеет";
            this.SickButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ErrorLabel.Location = new System.Drawing.Point(119, 545);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(268, 51);
            this.ErrorLabel.TabIndex = 30;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.ErrorLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.Location = new System.Drawing.Point(472, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 30);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(499, 30);
            this.TopPanel.TabIndex = 29;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // textBoxIncPeriod
            // 
            this.textBoxIncPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxIncPeriod.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIncPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxIncPeriod.Location = new System.Drawing.Point(12, 505);
            this.textBoxIncPeriod.Multiline = true;
            this.textBoxIncPeriod.Name = "textBoxIncPeriod";
            this.textBoxIncPeriod.Size = new System.Drawing.Size(168, 34);
            this.textBoxIncPeriod.TabIndex = 28;
            // 
            // HealthyButton
            // 
            this.HealthyButton.AutoSize = true;
            this.HealthyButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HealthyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HealthyButton.Location = new System.Drawing.Point(302, 381);
            this.HealthyButton.Name = "HealthyButton";
            this.HealthyButton.Size = new System.Drawing.Size(153, 46);
            this.HealthyButton.TabIndex = 26;
            this.HealthyButton.TabStop = true;
            this.HealthyButton.Text = "Здоров";
            this.HealthyButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSpeedY
            // 
            this.textBoxSpeedY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxSpeedY.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpeedY.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSpeedY.Location = new System.Drawing.Point(302, 253);
            this.textBoxSpeedY.Multiline = true;
            this.textBoxSpeedY.Name = "textBoxSpeedY";
            this.textBoxSpeedY.Size = new System.Drawing.Size(168, 34);
            this.textBoxSpeedY.TabIndex = 22;
            // 
            // textBoxSpeedX
            // 
            this.textBoxSpeedX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxSpeedX.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpeedX.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSpeedX.Location = new System.Drawing.Point(49, 253);
            this.textBoxSpeedX.Multiline = true;
            this.textBoxSpeedX.Name = "textBoxSpeedX";
            this.textBoxSpeedX.Size = new System.Drawing.Size(168, 34);
            this.textBoxSpeedX.TabIndex = 21;
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxCoordX.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCoordX.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxCoordX.Location = new System.Drawing.Point(49, 127);
            this.textBoxCoordX.Multiline = true;
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.Size = new System.Drawing.Size(168, 34);
            this.textBoxCoordX.TabIndex = 18;
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxCoordY.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCoordY.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxCoordY.Location = new System.Drawing.Point(302, 127);
            this.textBoxCoordY.Multiline = true;
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.Size = new System.Drawing.Size(168, 34);
            this.textBoxCoordY.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 427);
            this.label1.TabIndex = 15;
            this.label1.Text = "Координаты\r\nX:                        Y:\r\n\r\nСкорость \r\nX:                        " +
    "Y:\r\n\r\nСтатус болезни\r\n\r\n\r\nИнкубационный период";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NextButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextButton.Location = new System.Drawing.Point(119, 596);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(268, 61);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Продолжить";
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.NextButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(0, 33, 0, 0);
            this.Title.Size = new System.Drawing.Size(499, 76);
            this.Title.TabIndex = 13;
            this.Title.Text = "Человек №...";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // SimplePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 679);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimplePeopleForm";
            this.Text = "SimplePeopleForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Label CloseButton;
        private Label NextButton;
        private Label Title;
        private Label label1;
        private Label label5;
        private TextBox textBoxSpeedY;
        private TextBox textBoxSpeedX;
        private Label label4;
        private Label label3;
        private TextBox textBoxCoordX;
        private TextBox textBoxCoordY;
        private Label label2;
        private RadioButton SickButton;
        private RadioButton HealthyButton;
        private TextBox textBoxIncPeriod;
        private Label label6;
        private Panel TopPanel;
        private Label ErrorLabel;
    }
}