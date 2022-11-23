using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagueModel_Cs
{
    abstract public class Human
    {
        public float xCoord, yCoord, xSpeed, ySpeed;
        protected Model _model;
        public float XCoord
        {
            get { return xCoord; }
            set
            {
                if (Math.Abs(value) > _model.XSize)
                    throw new ArgumentException();
                xCoord = value;
            }
        }
        public float YCoord
        {
            get { return yCoord; }
            set
            {
                if (Math.Abs(value) > _model.YSize)
                    throw new ArgumentException();
                yCoord = value;
            }
        }
        public float XSpeed { get; set; }
        public float YSpeed { get; set; }

        public Human(string coordX, string coordY, string speedX, string speedY)
        {
            try
            {
                XCoord = Convert.ToSingle(coordX);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Координата Х должна быть числом и не превышать размер карты");
            }

            try
            {
                YCoord = Convert.ToSingle(coordY);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Координата Y должна быть числом и не превышать размеры карты");
            }

            try
            {
                XSpeed = Convert.ToSingle(speedX);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Скорость Х должна быть числом");
            }

            try
            {
                YSpeed = Convert.ToSingle(speedY);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Скорость Y должна быть числом");
            }
        }
    }
}
