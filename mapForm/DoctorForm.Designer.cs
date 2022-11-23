namespace PlagueModel_Cs
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.textBoxSpeedY = new System.Windows.Forms.TextBox();
            this.textBoxSpeedX = new System.Windows.Forms.TextBox();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSpeedY
            // 
            this.textBoxSpeedY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.textBoxSpeedY, "textBoxSpeedY");
            this.textBoxSpeedY.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSpeedY.Name = "textBoxSpeedY";
            // 
            // textBoxSpeedX
            // 
            this.textBoxSpeedX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.textBoxSpeedX, "textBoxSpeedX");
            this.textBoxSpeedX.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSpeedX.Name = "textBoxSpeedX";
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.textBoxCoordX, "textBoxCoordX");
            this.textBoxCoordX.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxCoordX.Name = "textBoxCoordX";
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.textBoxCoordY, "textBoxCoordY");
            this.textBoxCoordY.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxCoordY.Name = "textBoxCoordY";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextButton.Name = "NextButton";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.NextButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Name = "Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.textBoxSpeedY);
            this.MainPanel.Controls.Add(this.textBoxSpeedX);
            this.MainPanel.Controls.Add(this.textBoxCoordX);
            this.MainPanel.Controls.Add(this.textBoxCoordY);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.NextButton);
            this.MainPanel.Controls.Add(this.Title);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // DoctorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxSpeedY;
        private TextBox textBoxSpeedX;
        private TextBox textBoxCoordX;
        private TextBox textBoxCoordY;
        private Label label1;
        private Label CloseButton;
        private Label NextButton;
        private Label Title;
        private Panel MainPanel;
        private Panel TopPanel;
        private Label ErrorLabel;
    }
}