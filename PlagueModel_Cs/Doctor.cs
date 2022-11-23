using System;

namespace PlagueModel_Cs
{
    public class Doctor
    {
        public float xCoord, yCoord, xSpeed, ySpeed;
        public float XCoord
        {
            get { return xCoord; }
            set 
            {
                if (Math.Abs(value) > Model.xSize)
                    throw new ArgumentOutOfRangeException("The person outside the map");
                xCoord = value; 
            }
        }
        public float YCoord
        {
            set
            {
                if (Math.Abs(value) > Model.ySize)
                    throw new ArgumentOutOfRangeException("The person outside the map");
                yCoord = value;
            }
            get { return yCoord; }
        }
        public float XSpeed { get; set; } = 0;
        public float YSpeed { get; set; } = 0;

        public void positionUpdate()
        {
            XCoord += xSpeed;
            YCoord += ySpeed;
        }
        public void treat(SimplePeople ppl)
        {
            ppl.sickStatusUpdate(false);
        }
        public override string ToString()
        {
            return "X coord: " + XCoord +
            "\nY coord: " + YCoord +
            "\nX speed: " + XSpeed +
            "\nY speed: " + YSpeed + "\n";
        }

        public static Doctor inputDoctor()
        {
            Doctor temp_doc = new Doctor();
            float xC = 0, yC = 0, xS = 0, yS = 0;
            bool safetyFlag = true;
            string input;

            //xCoord
            while (safetyFlag == true)
            {
                Console.WriteLine("Input x coordinate: ");
                input = Console.ReadLine();

                try
                {
                    xC = Convert.ToSingle(input);
                    safetyFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
            }
            safetyFlag = true;

            //yCoord
            while (safetyFlag == true)
            {
                Console.WriteLine("Input y coordinate: ");
                input = Console.ReadLine();

                try
                {
                    yC = Convert.ToSingle(input);
                    safetyFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                    Console.WriteLine("\n");
                }
            }
            safetyFlag = true;

            //xSpeed
            while (safetyFlag == true)
            {
                Console.WriteLine("Enter x speed: ");
                input = Console.ReadLine();

                try
                {
                    xS = Convert.ToSingle(input);
                    safetyFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
            }
            safetyFlag = true;

            //ySpeed
            while (safetyFlag == true)
            {
                Console.WriteLine("Enter y speed: ");
                input = Console.ReadLine();

                try
                {
                    yS = Convert.ToSingle(input);
                    safetyFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                    Console.WriteLine("\n");
                }
            }

            temp_doc.XCoord = xC;
            temp_doc.YCoord = yC;
            temp_doc.XSpeed = xS;
            temp_doc.YSpeed = yS;

            return temp_doc;
        }
    }
}
