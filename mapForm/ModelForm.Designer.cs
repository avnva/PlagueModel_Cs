namespace PlagueModel_Cs
{
    partial class ModelForm
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Label();
            this.textBoxXSize = new System.Windows.Forms.TextBox();
            this.textBoxDocCount = new System.Windows.Forms.TextBox();
            this.textBoxPplCount = new System.Windows.Forms.TextBox();
            this.textBoxYSize = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.NextButton);
            this.MainPanel.Controls.Add(this.textBoxXSize);
            this.MainPanel.Controls.Add(this.textBoxDocCount);
            this.MainPanel.Controls.Add(this.textBoxPplCount);
            this.MainPanel.Controls.Add(this.textBoxYSize);
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(451, 450);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ErrorLabel.Location = new System.Drawing.Point(92, 298);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(268, 53);
            this.ErrorLabel.TabIndex = 14;
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
            this.CloseButton.Location = new System.Drawing.Point(424, 0);
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
            this.TopPanel.Size = new System.Drawing.Size(451, 30);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NextButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextButton.Location = new System.Drawing.Point(92, 351);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(268, 61);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Продолжить";
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseDown);
            this.NextButton.MouseEnter += new System.EventHandler(this.NextButton_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.NextButton_MouseLeave);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseUp);
            // 
            // textBoxXSize
            // 
            this.textBoxXSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxXSize.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxXSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxXSize.Location = new System.Drawing.Point(49, 83);
            this.textBoxXSize.Multiline = true;
            this.textBoxXSize.Name = "textBoxXSize";
            this.textBoxXSize.Size = new System.Drawing.Size(168, 34);
            this.textBoxXSize.TabIndex = 10;
            // 
            // textBoxDocCount
            // 
            this.textBoxDocCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxDocCount.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDocCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxDocCount.Location = new System.Drawing.Point(285, 252);
            this.textBoxDocCount.Multiline = true;
            this.textBoxDocCount.Name = "textBoxDocCount";
            this.textBoxDocCount.Size = new System.Drawing.Size(159, 34);
            this.textBoxDocCount.TabIndex = 9;
            // 
            // textBoxPplCount
            // 
            this.textBoxPplCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxPplCount.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPplCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPplCount.Location = new System.Drawing.Point(238, 162);
            this.textBoxPplCount.Multiline = true;
            this.textBoxPplCount.Name = "textBoxPplCount";
            this.textBoxPplCount.Size = new System.Drawing.Size(206, 34);
            this.textBoxPplCount.TabIndex = 6;
            // 
            // textBoxYSize
            // 
            this.textBoxYSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.textBoxYSize.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxYSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxYSize.Location = new System.Drawing.Point(271, 83);
            this.textBoxYSize.Multiline = true;
            this.textBoxYSize.Name = "textBoxYSize";
            this.textBoxYSize.Size = new System.Drawing.Size(168, 34);
            this.textBoxYSize.TabIndex = 3;
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Padding = new System.Windows.Forms.Padding(0, 33, 0, 0);
            this.MainLabel.Size = new System.Drawing.Size(451, 298);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Размер карты\r\nX:                     Y:\r\n\r\nЧисло людей:\r\n\r\nЧисло докторов:";
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ModelForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModelForms";
            this.Text = "ModelForms";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private TextBox textBoxXSize;
        private TextBox textBoxDocCount;
        private TextBox textBoxPplCount;
        private TextBox textBoxYSize;
        private Label MainLabel;
        private Label CloseButton;
        private Label NextButton;
        private Panel TopPanel;
        private Label ErrorLabel;
    }
}