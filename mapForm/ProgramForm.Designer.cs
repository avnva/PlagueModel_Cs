namespace PlagueModel_Cs
{
    partial class ProgramForm
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
            this.StepButton = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CountPplAndDocLabel = new System.Windows.Forms.Label();
            this.MapInfoLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.IndexDOCTextBox = new System.Windows.Forms.TextBox();
            this.IndexSPTextBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AddDoc = new System.Windows.Forms.Label();
            this.AddSP = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.MainPanel.Controls.Add(this.StepButton);
            this.MainPanel.Controls.Add(this.InfoPanel);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.SearchButton);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.IndexDOCTextBox);
            this.MainPanel.Controls.Add(this.IndexSPTextBox);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.AddDoc);
            this.MainPanel.Controls.Add(this.AddSP);
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1147, 685);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // StepButton
            // 
            this.StepButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.StepButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StepButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.StepButton.Location = new System.Drawing.Point(12, 611);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(268, 61);
            this.StepButton.TabIndex = 43;
            this.StepButton.Text = "Сделать ход";
            this.StepButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            this.StepButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StepButton_MouseDown);
            this.StepButton.MouseEnter += new System.EventHandler(this.StepButton_MouseEnter);
            this.StepButton.MouseLeave += new System.EventHandler(this.StepButton_MouseLeave);
            this.StepButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StepButton_MouseUp);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoPanel.Location = new System.Drawing.Point(324, 36);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(811, 587);
            this.InfoPanel.TabIndex = 43;
            this.InfoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.InfoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panel3.Location = new System.Drawing.Point(288, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 656);
            this.panel3.TabIndex = 42;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 154);
            this.panel1.TabIndex = 41;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 10);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(268, 131);
            this.ErrorLabel.TabIndex = 25;
            this.ErrorLabel.Text = "\r\n";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.ErrorLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panel2.Controls.Add(this.CountPplAndDocLabel);
            this.panel2.Controls.Add(this.MapInfoLabel);
            this.panel2.Location = new System.Drawing.Point(288, 629);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 56);
            this.panel2.TabIndex = 42;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // CountPplAndDocLabel
            // 
            this.CountPplAndDocLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountPplAndDocLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.CountPplAndDocLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CountPplAndDocLabel.Location = new System.Drawing.Point(594, 0);
            this.CountPplAndDocLabel.Name = "CountPplAndDocLabel";
            this.CountPplAndDocLabel.Size = new System.Drawing.Size(265, 56);
            this.CountPplAndDocLabel.TabIndex = 27;
            this.CountPplAndDocLabel.Text = "\r\n";
            this.CountPplAndDocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CountPplAndDocLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.CountPplAndDocLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MapInfoLabel
            // 
            this.MapInfoLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MapInfoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MapInfoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MapInfoLabel.Location = new System.Drawing.Point(32, 0);
            this.MapInfoLabel.Name = "MapInfoLabel";
            this.MapInfoLabel.Size = new System.Drawing.Size(542, 56);
            this.MapInfoLabel.TabIndex = 26;
            this.MapInfoLabel.Text = "\r\n";
            this.MapInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapInfoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MapInfoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchButton.Location = new System.Drawing.Point(12, 377);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(133, 61);
            this.SearchButton.TabIndex = 40;
            this.SearchButton.Text = "Найти";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseDown);
            this.SearchButton.MouseEnter += new System.EventHandler(this.SearchButton_MouseEnter);
            this.SearchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
            this.SearchButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseUp);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeleteButton.Location = new System.Drawing.Point(151, 377);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 61);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseDown);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.DeleteButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            this.DeleteButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseUp);
            // 
            // IndexDOCTextBox
            // 
            this.IndexDOCTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IndexDOCTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IndexDOCTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.IndexDOCTextBox.Location = new System.Drawing.Point(12, 330);
            this.IndexDOCTextBox.Multiline = true;
            this.IndexDOCTextBox.Name = "IndexDOCTextBox";
            this.IndexDOCTextBox.Size = new System.Drawing.Size(268, 34);
            this.IndexDOCTextBox.TabIndex = 37;
            // 
            // IndexSPTextBox
            // 
            this.IndexSPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IndexSPTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IndexSPTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.IndexSPTextBox.Location = new System.Drawing.Point(12, 219);
            this.IndexSPTextBox.Multiline = true;
            this.IndexSPTextBox.Name = "IndexSPTextBox";
            this.IndexSPTextBox.Size = new System.Drawing.Size(268, 34);
            this.IndexSPTextBox.TabIndex = 35;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1147, 30);
            this.TopPanel.TabIndex = 34;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(1120, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 30);
            this.CloseButton.TabIndex = 35;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AddDoc
            // 
            this.AddDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddDoc.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddDoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddDoc.Location = new System.Drawing.Point(12, 109);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(268, 61);
            this.AddDoc.TabIndex = 13;
            this.AddDoc.Text = "Добавить доктора";
            this.AddDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            this.AddDoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddDoc_MouseDown);
            this.AddDoc.MouseEnter += new System.EventHandler(this.AddDoc_MouseEnter);
            this.AddDoc.MouseLeave += new System.EventHandler(this.AddDoc_MouseLeave);
            this.AddDoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddDoc_MouseUp);
            // 
            // AddSP
            // 
            this.AddSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddSP.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddSP.Location = new System.Drawing.Point(12, 36);
            this.AddSP.Name = "AddSP";
            this.AddSP.Size = new System.Drawing.Size(268, 61);
            this.AddSP.TabIndex = 12;
            this.AddSP.Text = "Добавить человека";
            this.AddSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSP.Click += new System.EventHandler(this.AddSP_Click);
            this.AddSP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddSP_MouseDown);
            this.AddSP.MouseEnter += new System.EventHandler(this.AddSP_MouseEnter);
            this.AddSP.MouseLeave += new System.EventHandler(this.AddSP_MouseLeave);
            this.AddSP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddSP_MouseUp);
            // 
            // MainLabel
            // 
            this.MainLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainLabel.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainLabel.Location = new System.Drawing.Point(12, 33);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(276, 331);
            this.MainLabel.TabIndex = 36;
            this.MainLabel.Text = "\r\n\r\n\r\n\r\nНомер человека:\r\n\r\n\r\nНомер доктора:\r\n";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 685);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Label AddDoc;
        private Label AddSP;
        private Panel TopPanel;
        private Label CloseButton;
        private Label DeleteButton;
        private TextBox IndexDOCTextBox;
        private Label MainLabel;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label SearchButton;
        private Label StepButton;
        public FlowLayoutPanel InfoPanel;
        public TextBox IndexSPTextBox;
        private Label ErrorLabel;
        public Label MapInfoLabel;
        public Label CountPplAndDocLabel;
    }
}