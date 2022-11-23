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
    public partial class ProgramForm : Form
    {
        private Model _model;
        public ProgramForm()
        {
            InitializeComponent();

            this.MapInfoLabel.Text = "Размер карты: " + Model.XSize * 2 + "x" + Model.YSize * 2;
            this.CountPplAndDocLabel.Text = "Всего людей: " + (Model.Ppls.Count) +
                                          "\nВсего докторов: " + (Model.Docs.Count);
        }
        public static bool flag = true;


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

        private void AddSP_Click(object sender, EventArgs e)
        {
            if(flag == true)
            {
                SimplePeopleForm SPF = new SimplePeopleForm();
                flag = false;
                SPF.Show();
            }
        }

        private void AddSP_MouseEnter(object sender, EventArgs e)
        {
            AddSP.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void AddSP_MouseLeave(object sender, EventArgs e)
        {
            AddSP.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void AddSP_MouseDown(object sender, MouseEventArgs e)
        {
            AddSP.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        private void AddSP_MouseUp(object sender, MouseEventArgs e)
        {
            AddSP.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void AddDoc_MouseDown(object sender, MouseEventArgs e)
        {
            AddDoc.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        private void AddDoc_MouseEnter(object sender, EventArgs e)
        {
            AddDoc.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void AddDoc_MouseLeave(object sender, EventArgs e)
        {
            AddDoc.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void AddDoc_MouseUp(object sender, MouseEventArgs e)
        {
            AddDoc.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void AddDoc_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                DoctorForm SPF = new DoctorForm();
                flag = false;
                SPF.Show();
            }
        }

        private void DeleteButton_MouseDown(object sender, MouseEventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void DeleteButton_MouseUp(object sender, MouseEventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ind;
            try
            {
                if (IndexSPTextBox.Text != "")
                {
                    ind = int.Parse(IndexSPTextBox.Text) - 1;
                    if (ind < 0 || ind > (Model.Ppls.Count - 1)) throw new ArgumentException();
                    Model.Ppls.RemoveAt(ind);
                }
                else if (IndexDOCTextBox.Text != "")
                {
                    ind = int.Parse(IndexDOCTextBox.Text) - 1;
                    if (ind < 0 || ind > (Model.Docs.Count - 1)) throw new ArgumentException();
                    Model.Docs.RemoveAt(ind);

                }
                Model.indexPeople = 1;
                Model.indexDoctor = 1;
                this.InfoPanel.Controls.Clear();
                for (int i = 0; i < Model.Ppls.Count; i++)
                {
                    SimplePeople.AddPeople(Model.Ppls[i]);
                }
                for (int i = 0; i < Model.Docs.Count; i++)
                {
                    Doctor.AddDoctor(Model.Docs[i]);
                }
                this.MapInfoLabel.Text = "Размер карты: " + Model.XSize * 2 + "x" + Model.YSize * 2;
                this.CountPplAndDocLabel.Text = "Всего людей: " + (Model.Ppls.Count) +
                                              "\nВсего докторов: " + (Model.Docs.Count);
                ErrorLabel.Text = "";
            } catch (Exception ex)
            {
                ErrorLabel.Text = "Не удается найти номер человека/доктора";
            }
        }

        private void StepButton_Click(object sender, EventArgs e)
        { 
            Model.updateAgentStatus(1);
            this.InfoPanel.Controls.Clear();
            Model.indexPeople = 1;
            Model.indexDoctor = 1;
            for (int i = 0; i < Model.Ppls.Count; i++)
            {
                SimplePeople.AddPeople(Model.Ppls[i]);
            }
            for (int i = 0; i < Model.Docs.Count; i++)
            {
                Doctor.AddDoctor(Model.Docs[i]);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (IndexSPTextBox.Text != "" && Model.Ppls.Count > 1)
                {
                    int indSP = int.Parse(IndexSPTextBox.Text);
                    if (indSP < 0 || indSP > (Model.Ppls.Count)) throw new ArgumentException();
                    this.InfoPanel.Controls.Clear();
                    Model.indexPeople = indSP;
                    SimplePeople.AddPeople(Model.Ppls[indSP - 1]);
                    Model.indexPeople = 1;
                    Model.indexDoctor = 1;
                    for (int i = 0; i < Model.Ppls.Count; i++)
                    {
                        if (i == (indSP - 1))
                        {
                            Model.indexPeople++;
                            continue;
                        }
                        SimplePeople.AddPeople(Model.Ppls[i]);
                    }
                    for (int i = 0; i < Model.Docs.Count; i++)
                    {
                        Doctor.AddDoctor(Model.Docs[i]);
                    }
                }
                else if (IndexDOCTextBox.Text != "" && Model.Docs.Count > 1)
                {
                    int indDOC = int.Parse(IndexDOCTextBox.Text);
                    if (indDOC < 0 || indDOC > (Model.Docs.Count)) throw new ArgumentException();
                    this.InfoPanel.Controls.Clear();
                    Model.indexDoctor = indDOC;
                    Doctor.AddDoctor(Model.Docs[indDOC - 1]);
                    Model.indexDoctor = 1;
                    Model.indexPeople = 1;
                    for (int i = 0; i < Model.Ppls.Count; i++)
                    {
                        SimplePeople.AddPeople(Model.Ppls[i]);
                    }
                    for (int i = 0; i < Model.Docs.Count; i++)
                    {
                        if (i == (indDOC - 1))
                        {
                            Model.indexDoctor++;
                            continue;
                        }
                        Doctor.AddDoctor(Model.Docs[i]);
                    }
                }
                ErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "Не удается найти номер человека/доктора";
            }
        }

        private void SearchButton_MouseDown(object sender, MouseEventArgs e)
        {
            SearchButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            SearchButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void SearchButton_MouseUp(object sender, MouseEventArgs e)
        {
            SearchButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void StepButton_MouseDown(object sender, MouseEventArgs e)
        {
            StepButton.BackColor = Color.FromArgb(255, 64, 8, 8);
        }

        private void StepButton_MouseEnter(object sender, EventArgs e)
        {
            StepButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }

        private void StepButton_MouseLeave(object sender, EventArgs e)
        {
            StepButton.BackColor = Color.FromArgb(255, 205, 79, 79);
        }

        private void StepButton_MouseUp(object sender, MouseEventArgs e)
        {
            StepButton.BackColor = Color.FromArgb(255, 169, 35, 35);
        }
    }
}
