using System;

namespace PlagueModel_Cs
{
    public class SimplePeople : Doctor
    {
        public float xCoord, yCoord, xSpeed, ySpeed;
        private bool infective;
        private int incubationPeriod;
        public int IncubationPeriod
        {
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("The period cannot be negative");
                incubationPeriod = value; 
            }
            get { return incubationPeriod; }
        }
        public bool Infective { get; set; } = false;

        //конструкторы
        public SimplePeople()
        {
            xCoord = 0;
            yCoord = 0;
            xSpeed = 0;
            ySpeed = 0;
            incubationPeriod = 0;
            infective = false;
        }
        public SimplePeople(SimplePeople other)
        {
            xCoord = other.xCoord;
            yCoord = other.yCoord;
            xSpeed = other.xSpeed;
            ySpeed = other.ySpeed;;
            incubationPeriod = other.incubationPeriod;
            infective = other.infective;
        }
        public SimplePeople(float x, float y, float xspeed, float yspeed)
        {
            xCoord = x;
            yCoord = y;
            xSpeed = xspeed;
            ySpeed = yspeed;
            incubationPeriod = 0;
            infective = false;
        }
        public SimplePeople(float x, float y, float xspeed, float yspeed, int incubPer, bool inf)
        {
            XCoord = x;
            YCoord = y;
            XSpeed = xspeed;
            YSpeed = yspeed;
            IncubationPeriod = incubPer;
            Infective = inf;
        }
        public void sickStatusUpdate(bool sick)
        {
            infective = sick;
            incubationPeriod = 2;
        }
        public override string ToString()
        {
            if(Infective == true)
            {
                return "X coord: " + XCoord +
                "\nY coord: " + YCoord +
                "\nX speed: " + XSpeed +
                "\nY speed: " + YSpeed +
                "\nIncubation period: " + IncubationPeriod +
                "\nSick status: " + Infective + "- is ill\n";
            }
            else
            {
                return "X coord: " + XCoord +
                "\nY coord: " + YCoord +
                "\nX speed: " + XSpeed +
                "\nY speed: " + YSpeed +
                "\nIncubation period: " + IncubationPeriod +
                "\nSick status: " + Infective + "- isn't ill\n";
            }
        }
        public static SimplePeople inputPeople()
        {
            SimplePeople temp_ppl = new SimplePeople();
            float xC = 0, yC = 0, xS = 0, yS = 0;
            bool sickStat = false, safetyFlag = true;
            int incPer = 0;
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
                }
            }
            safetyFlag = true;

            //sickStatus infective
            while (safetyFlag == true)
            {
                Console.WriteLine("Enter sick status: ");
                input = Console.ReadLine();
                try
                {
                    if (input == "True") input = "1";
                    if (input == "False") input = "0";
                    sickStat = bool.Parse(input);
                    safetyFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
            }
            safetyFlag = true;

            //incubationPeriod
            while (safetyFlag == true)
            {
                if (temp_ppl.Infective == false)
                    safetyFlag = false;
                Console.WriteLine("Enter incubation period: ");
                input = Console.ReadLine();
                try
                {
                    incPer = int.Parse(input);
                    safetyFlag = false;
                    if (incPer < 0)
                    {
                        safetyFlag = true;
                        throw new ArgumentException("Negative incubation period");
                    }
                }
                catch (Exception ex)
                {
                    safetyFlag = true;
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
                Console.WriteLine("\n");
            }

            temp_ppl.XCoord = xC;
            temp_ppl.YCoord = yC;
            temp_ppl.XSpeed = xS;
            temp_ppl.YSpeed = yS;
            temp_ppl.Infective = sickStat;
            temp_ppl.IncubationPeriod = incPer;

            return temp_ppl;
        }
    }
}
