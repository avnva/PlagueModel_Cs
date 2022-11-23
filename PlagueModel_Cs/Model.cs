using System;
using System.Collections.Generic;

namespace PlagueModel_Cs
{
    public class Model
    {
        public static float xSize, ySize;
        private int peoplesCount, doctorsCount;
        private List<SimplePeople> ppls; 
        private List<Doctor> docs;
        
        public float XSize
        {
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("The size cannot be negative");
                xSize = value; 
            }
            get { return xSize; }
        }
        public float YSize
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("The size cannot be negative");
                ySize = value;
            }
            get { return ySize; }
        }
        public int PeoplesCount
        {
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("Negative number of people");
                peoplesCount = value;
            }
            get { return peoplesCount; }
        }
        public int DoctorsCount
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Negative number of doctor"); 
                doctorsCount = value; 
            }
            get { return doctorsCount; }
        }
        public List<SimplePeople> Ppls
        {
            set { ppls = value; }
            get { return ppls; }
        }
        public List<Doctor> Docs
        {
            set { docs = value; }
            get { return docs; }
        }

        //конструктор по умолчанию
        public Model()
        {
            xSize = 0;
            ySize = 0;
            peoplesCount = 0;
            doctorsCount = 0;
            ppls = new List<SimplePeople>();
            docs = new List<Doctor>();
        }

        //конструктор с параметрами
        public Model(float sizeX, float sizeY, int countPpls, int countDocs)
        {
            XSize = sizeX;
            YSize = sizeY;
            PeoplesCount = countPpls;
            DoctorsCount = countDocs;
            if (countPpls != 0)
                ppls = new List<SimplePeople>(new SimplePeople[countPpls]);
            else
                ppls = new List<SimplePeople>();
            if (countDocs != 0)
                docs = new List<Doctor>(new Doctor[countDocs]);
        	else
        		docs = new List<Doctor>();
        }

        // консутрктор копирования
        public Model(Model other)
        {
            xSize = other.XSize;
            ySize = other.YSize;
            peoplesCount = other.PeoplesCount;
            doctorsCount = other.DoctorsCount;
            
            for (int i = 0; i < peoplesCount; i++)
            {
                ppls.Add(other.Ppls[i]);
            }

            for (int i = 0; i < doctorsCount; i++)
            {
                docs.Add(other.Docs[i]);
            }
        }

        // методы подсчета расстояния от человека к человеку/доктору
        double distancePplDoc(SimplePeople ppl, Doctor doc) 
        {
            float xppl = ppl.XCoord;
            float yppl = ppl.YCoord;
            float xdoc = doc.XCoord;
            float ydoc = doc.YCoord;

            double dist = Math.Sqrt(Math.Pow(xppl - xdoc, 2) + Math.Pow(yppl - ydoc, 2));            
	        return dist;
        }
        double distancePplPpl(SimplePeople ppl1, SimplePeople ppl2)
        {
            float xppl1 = ppl1.XCoord;
            float yppl1 = ppl1.YCoord;
            float xppl2 = ppl2.XCoord;
            float yppl2 = ppl2.YCoord;

            double dist = Math.Sqrt(Math.Pow(xppl1 - xppl2, 2) + Math.Pow(yppl1 - yppl2, 2));
            return dist;
        }
        // проверка на выход за рамки поля, изменение направления в противном случае
        private void CheckExit(int dt, int i)
        {
            if (ppls[i].XCoord > xSize)
            {
                ppls[i].XCoord = xSize;
                ppls[i].XSpeed = -ppls[i].XSpeed;
            }
            if (ppls[i].XCoord < -xSize)
            {
                ppls[i].XCoord = -xSize;
                ppls[i].XSpeed = -ppls[i].XSpeed;
            }
            if (ppls[i].YCoord > ySize)
            {
                ppls[i].YCoord = ySize;
                ppls[i].YSpeed = -ppls[i].YSpeed;
            }
            if (ppls[i].YCoord < -ySize)
            {
                ppls[i].YCoord = -ySize;
                ppls[i].YSpeed = -ppls[i].YSpeed;
            }
        }
        // меняем инукубационный период людей
        private void ChangeIncPeriod(int i)
        {
            if (ppls[i].IncubationPeriod != 0)
            {
                ppls[i].IncubationPeriod = ppls[i].IncubationPeriod - 1;
                if (ppls[i].IncubationPeriod == 0)
                {
                    ppls[i].Infective = true;
                }
            }
        }
        // проверка заражённых рядом, заражение(установка инкубационного периода)
        private void SettingIncPeriod(int i)
        {
            for (int j = 0; j < Ppls.Count; j++)
            {
                if (distancePplPpl(ppls[i], ppls[j]) < 2)
                {
                    if (ppls[j].Infective == true)
                    {
                        if (ppls[i].Infective == false)
                        {
                            ppls[i].IncubationPeriod = 2;
                            ppls[i].Infective = true;
                        }
                    }
                }
            }
        }
        // доктора лечат всех рядом стоящих людей на момент dt
        private void Healing(int i)
        {
            for (int j = 0; j < Docs.Count; j++)
            {
                if (distancePplDoc(ppls[i], docs[j]) < 2)
                {
                    ppls[i].sickStatusUpdate(false);
                    ppls[i].IncubationPeriod = 0;
                    ppls[i].Infective = false;
                }
            }
        }
        // обновление состояний агентов с временем dt
        public void updateAgentStatus(int dt)
        {
            int step = 0;
            while (step < dt)
            {
                //действия с людьми
                for (int i = 0; i < Ppls.Count; i++)
                {
                    CheckExit(dt, i);
                    ChangeIncPeriod(i);
                    SettingIncPeriod(i);
                    Healing(i);
                    ppls[i].positionUpdate();

                }

                //действия с докторами
                for (int j = 0; j < Docs.Count; j++)
                {
                    CheckExit(dt, j);
                    docs[j].positionUpdate();
                }
                step++;
            }
        }

        public override string ToString()
        {
            string result_peoples = string.Empty;
            string result_docs = string.Empty;
            if (Ppls.Count == 0)
                result_peoples = "No peoples\n";
            else
            {
                for (int i = 0; i < Ppls.Count; i++)
                {
                    result_peoples += "People #" + (i + 1) + "\n" + ppls[i] + "\n";
                }
            }

            if (Docs.Count == 0)
                result_docs = "No doctors\n";
            else
            {
                for (int i = 0; i < Docs.Count; i++)
                {
                    result_docs += "Doctor #" + (i + 1) + "\n" + docs[i] + "\n";
                }
            }


            return result_peoples + result_docs;
        }
    }
}
