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
    public partial class DoctorForm : Form
    {
        private Model _model;
        public DoctorForm(Model model)
        {
            InitializeComponent();
            _model = model;
            Title.Text = "Доктор №" + _model.indexDoctor;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (ProgramForm.flag == false)
            {
                this.Hide();
                ProgramForm.flag = true;
            }
            else Application.Exit();
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
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            String XCoord = textBoxCoordX.Text,
            YCoord = textBoxCoordY.Text,
            XSpeed = textBoxSpeedX.Text,
            YSpeed = textBoxSpeedY.Text;
            try
            {
                Doctor tempDOC = new Doctor(XCoord, YCoord, XSpeed, YSpeed);
                _model.Docs.Add(tempDOC);
                Doctor.AddDoctor(_model.Docs[_model.Docs.Count - 1]);
                ModelForm.PF.CountPplAndDocLabel.Text = "Всего людей: " + (_model.Ppls.Count) +
                                              "\nВсего докторов: " + (_model.Docs.Count);
                if (ProgramForm.flag == false)
                {
                    this.Hide();
                    ProgramForm.flag = true;
                }
                else if (_model.indexDoctor <= _model.DoctorsCount)
                {
                    DoctorForm DF = new DoctorForm();
                    DF.Show();
                    this.Hide();
                }
                else
                {
                    ModelForm.PF.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }
    }
}
