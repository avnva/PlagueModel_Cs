using System;

namespace PlagueModel_Cs
{
    public class Doctor : Human
    {
        

        public Doctor() : base("0", "0", "0", "0") {}

        public Doctor(string coordX, string coordY, string speedX, string speedY) : base(coordX, coordY, speedX, speedY) {}
        
        public void positionUpdate()
        {
            xCoord += XSpeed;
            yCoord += YSpeed;
            if (xCoord > _model.XSize)
            {
                XCoord = _model.XSize;
                XSpeed = -XSpeed;
            }
            if (xCoord < -_model.XSize)
            {
                XCoord = -_model.XSize;
                XSpeed = -XSpeed;
            }
            if (yCoord > _model.YSize)
            {
                YCoord = _model.YSize;
                YSpeed = -YSpeed;
            }
            if (yCoord < -_model.YSize)
            {
                YCoord = -_model.YSize;
                YSpeed = -YSpeed;
            }
        }
        public void AddDoctor(Doctor DOC)
        {
            ModelForm.PF.InfoPanel.Controls.Add(new Label()
            {
                Width = 250,
                Height = 200,
                ForeColor = Color.Gainsboro,
                BackColor = Color.FromArgb(64, 8, 8),
                Font = ModelForm.PF.InfoPanel.Font,
                BorderStyle = ModelForm.PF.IndexSPTextBox.BorderStyle,
                Text = "         Доктор №" + _model.indexDoctor +
                "\nX координата: " + DOC.XCoord +
                "\nY координата: " + DOC.YCoord +
                "\nX скорость: " + DOC.XSpeed +
                "\nY скорость: " + DOC.YSpeed
            });
            _model.indexDoctor++;
        }
    }
}
