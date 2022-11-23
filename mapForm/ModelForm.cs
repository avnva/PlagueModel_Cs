using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueModel_Cs
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }
        public ProgramForm PF = new ProgramForm();
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        public void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string xSize = textBoxXSize.Text,
            ySize = textBoxYSize.Text,
            Pplcount = textBoxPplCount.Text,
            DocCount = textBoxDocCount.Text;
            try
            {
                
                Model tempModel = new Model(xSize, ySize, Pplcount, DocCount);
                DoctorForm DF = new DoctorForm(tempModel);
                SimplePeopleForm SPF = new SimplePeopleForm(tempModel);


                if (tempModel.PeoplesCount == 0 && tempModel.DoctorsCount == 0)
                {
                    PF.Show();
                    this.Hide();
                }
                else if (tempModel.PeoplesCount == 0)
                {  
                    DF.Show();
                    this.Hide();
                }
                else
                {   
                    SPF.Show();
                    this.Hide();
                }
            }catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        private void NextButton_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }
        private void NextButton_MouseEnter(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }
        private void NextButton_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }
    }    
}
