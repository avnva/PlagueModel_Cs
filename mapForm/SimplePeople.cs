using System;

namespace PlagueModel_Cs
{
    public class SimplePeople : Human
    {
        private bool infective;
        private int incubationPeriod;

        
        public int IncubationPeriod 
        { 
            get 
            { 
                return incubationPeriod;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
            }
        } 
        public bool Infective { get; set; }
        //конструкторы
        public SimplePeople() : base("0","0","0","0")
        {
            incubationPeriod = 0;
            infective = false;
        }
        public SimplePeople(string coordX, string coordY, string speedX, string speedY, string incPeriod, bool status) 
            : base(coordX, coordY, speedX, speedY)
        {
            try
            {
                incubationPeriod = Convert.ToInt32(incPeriod);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Инкубационный период должен быть неотрицательным числом");
            }

            infective = status;

        }
       
        public void AddPeople(SimplePeople SP)
        { 
            ModelForm.PF.InfoPanel.Controls.Add(new Label()
            {
                Width = 250,
                Height = 200,
                ForeColor = Color.Gainsboro,
                BackColor = Color.FromArgb(205, 79, 79),
                Font = ModelForm.PF.InfoPanel.Font,
                BorderStyle = ModelForm.PF.IndexSPTextBox.BorderStyle,
                Text = "         Человек №" + _model.indexPeople +
                "\nX координата: " + SP.xCoord +
                "\nY координата: " + SP.yCoord +
                "\nX скорость: " + SP.XSpeed +
                "\nY скорость: " + SP.YSpeed +
                "\nИнкубационный период: " + SP.incubationPeriod +
                "\nСтатус болезни: " + SP.infective,
            });
            _model.indexPeople++;
        }
    }
}
