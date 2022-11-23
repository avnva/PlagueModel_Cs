using System;
using System.Collections.Generic;

namespace PlagueModel_Cs
{
    public class Model
    {
        private float xSize, ySize;
        private int peoplesCount, doctorsCount;
        private List<SimplePeople> ppls;
        private List<Doctor> docs;
        public int indexPeople = 1, indexDoctor = 1;

        public float XSize
        {
            get { return xSize; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
            }
        }
        public float YSize
        {
            get { return ySize; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
            }
        }
        public int PeoplesCount 
        { 
            get 
            { 
                return peoplesCount;
            }
            set 
            {
                if (value < 0)
                    throw new ArgumentException();
            }
        }
        public int DoctorsCount
        {
            get
            {
                return doctorsCount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
            }
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
        public Model(string sizeX, string sizeY, string countPpls, string countDocs)
        {
            try
            {
                xSize = Convert.ToSingle(sizeX);
                
            } catch(Exception ex)
            {
                throw new ArgumentException("Размер X должен быть положительным числом");
            }
            try
            {
                ySize = Convert.ToSingle(sizeY);
                if (ySize <= 0)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Размер Y должен быть положительным числом");
            }
            try
            {
                peoplesCount = Convert.ToInt32(countPpls);
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Кол-во людей должно быть неотрицательным числом");
            }
            try
            {
                doctorsCount = Convert.ToInt32(countDocs);
                if (doctorsCount < 0)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Кол-во докторов должно быть неотрицательным числом");
            }
                Ppls = new List<SimplePeople>();
        		Docs = new List<Doctor>();
        }

        // методы подсчета расстояния от человека к человеку/доктору
        public bool IsAllPeopleField()
        {
            return indexPeople > PeoplesCount;
        }
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
        // меняем инукубационный период людей
        public void ChangeIncPeriod(int i)
        {
            if (ppls[i].IncubationPeriod != 0)
            {
                ppls[i].IncubationPeriod--;
                if (ppls[i].IncubationPeriod == 0)
                {
                    ppls[i].Infective = true;
                }
            }
        }
        // проверка заражённых рядом, заражение(установка инкубационного периода)
        public void SettingIncPeriod(int i)
        {
            for (int j = 1; j < ppls.Count; j++)
            {
                if (distancePplPpl(ppls[i], ppls[j]) < 2)
                {
                    if (ppls[j].Infective == true)
                    {
                        if (ppls[i].Infective == false && ppls[i].IncubationPeriod == 0)
                        {
                            ppls[i].IncubationPeriod = 2;
                        }
                    }
                }
            }
        }
        // доктора лечат всех рядом стоящих людей на момент dt
        public void Healing(int i)
        {
            for (int j = 1; j < docs.Count; j++)
            {
                if (distancePplDoc(ppls[i], docs[j]) < 2)
                {
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
                for (int i = 0; i < ppls.Count; i++)
                {
                    ppls[i].positionUpdate();
                    ChangeIncPeriod(i);
                    SettingIncPeriod(i);
                    Healing(i);
                }
                //действия с докторами
                for (int j = 0; j < docs.Count; j++)
                {
                    docs[j].positionUpdate();
                }
                step++;
            }
        }
    }
}
