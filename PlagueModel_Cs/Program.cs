using System;
using System.Collections.Generic;
using System.Text;

namespace PlagueModel_Cs
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Creating model.\n");
            float xSize = 0, ySize = 0;
            int pplsCount = -1, docsCount = -1, command = 0;
            bool safetyFlag = true;
            string input;

            while (xSize == 0)
            {
                try
                {
                    Console.WriteLine("Input x size of map: ");
                    input = Console.ReadLine();
                    xSize = Convert.ToSingle(input);
                }
                catch (Exception ex)
                {
                    xSize = 0;
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");

                }
            }

            while (ySize == 0)
            {
                Console.WriteLine("Input y size of map: ");
                input = Console.ReadLine();

                try
                {
                    ySize = Convert.ToSingle(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                    ySize = 0;
                }
            }

            while (pplsCount == -1)
            {
                Console.WriteLine("Enter the number of people: ");
                input = Console.ReadLine();

                try
                {
                    pplsCount = int.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
            }

            while (docsCount == -1)
            {
                Console.WriteLine("Enter the number of doctors: ");
                input = Console.ReadLine();

                try
                {
                    docsCount = int.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}\n");
                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                }
            }

            Console.WriteLine("\n");
            Model M = new Model();
            try
            {
                //создание экземпляра класса с помощью конструктора с параметрами
                Model test = new Model(xSize, ySize, pplsCount, docsCount);
                M = test;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught: {ex.Message}\n");
                Console.WriteLine($"Type: {ex.TargetSite}\n");
                Menu();
            }

            SimplePeople p = new SimplePeople();
            for (int i = 0; i < M.Ppls.Count; i++, safetyFlag = true)
            {
                while (safetyFlag == true)
                {
                    Console.WriteLine($"Enter the data about people # {i}:\n");
                    try
                    {
                        p = SimplePeople.inputPeople();
                        safetyFlag = false;
                        M.Ppls[i] = p;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Caught: {ex.Message}\n");
                        Console.WriteLine($"Type: {ex.TargetSite}\n");
                    }
                }
            }
            safetyFlag = true;

            Doctor d = new Doctor();
            for (int i = 0; i < M.Docs.Count; i++, safetyFlag = true)
            {
                while (safetyFlag == true)
                {
                    Console.WriteLine($"Enter the data about doctor # {i}:\n");
                    try
                    {
                        d = Doctor.inputDoctor();
                        safetyFlag = false;
                        M.Docs[i] = d;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Caught: {ex.Message}\n");
                        Console.WriteLine($"Type: {ex.TargetSite}\n");
                    }
                }
                Console.WriteLine("\n");
            }
            safetyFlag = true;
            Console.Clear();


            //ввод команды
            int ind = 0;
            int dt = 0;
            while (true)
            {
                Console.WriteLine("__________________________MENU__________________________");
                Console.WriteLine("1 - Print info about peoples & doctors");
                Console.WriteLine("2 - Print how many peoples");
                Console.WriteLine("3 - Print how many doctors");
                Console.WriteLine("4 - Print information about a person by number/index/id");
                Console.WriteLine("5 - Print information about a doctor by number/index/id");
                Console.WriteLine("6 - Push one more person in model");
                Console.WriteLine("7 - Push one more doctor in model");
                Console.WriteLine("8 - Delete a person by number/index/id");
                Console.WriteLine("9 - Delete a doctor by number/index/id");
                Console.WriteLine("10 - Make a change over time dt");
                Console.WriteLine("11 - Exit\n");

                while (safetyFlag == true)
                {
                    Console.WriteLine("Enter the command number: ");
                    try
                    {
                        input = Console.ReadLine();
                        command = int.Parse(input);
                        if (command > 11 || command < 1)
                            throw new ArgumentException("Unknow command");
                        safetyFlag = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Caught: {ex.Message}\n");
                        Console.WriteLine($"Type: {ex.TargetSite}\n");
                    }
                }
                safetyFlag = true;

                switch (command)
                {
                    case 1:
                        Console.WriteLine(M);
                        break;
                    case 2:
                        Console.WriteLine($"Total people: {M.Ppls.Count}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Total doctor: {M.Docs.Count}\n");
                        break;
                    case 4:
                        safetyFlag = true;
                        while (safetyFlag == true)
                        {
                            if (M.Ppls.Count == 0)
                            {
                                Console.WriteLine("No peoples!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input index: ");
                                input = Console.ReadLine();
                                try
                                {
                                    ind = int.Parse(input);
                                    safetyFlag = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Caught: {ex.Message}\n");
                                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                                }

                                try
                                {
                                    p = M.Ppls[ind];
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Caught: {ex.Message}\n");
                                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                                    break;
                                }
                                Console.WriteLine(p);
                                safetyFlag = true;
                                break;
                            }
                        }
                        break;

                    case 5:
                        safetyFlag = true;
                        while (safetyFlag == true)
                        {
                            if (M.Docs.Count == 0)
                            {
                                Console.WriteLine("No doctors!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input index: ");
                                input = Console.ReadLine();
                                try
                                {
                                    ind = int.Parse(input);
                                    safetyFlag = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Caught: {ex.Message}\n");
                                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                                }

                                try
                                {
                                    d = M.Docs[ind];
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Caught: {ex.Message}\n");
                                    Console.WriteLine($"Type: {ex.TargetSite}\n");
                                    break;
                                }
                                Console.WriteLine(d);
                                safetyFlag = true;
                                break;
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter the data about people: \n");
                        p = SimplePeople.inputPeople();
                        try
                        {
                            M.Ppls.Add(p);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Caught: {ex.Message}\n");
                            Console.WriteLine($"Type: {ex.TargetSite}\n");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter the data about doctor: \n");
                        d = Doctor.inputDoctor();
                        try
                        {
                            M.Docs.Add(d);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Caught: {ex.Message}\n");
                            Console.WriteLine($"Type: {ex.TargetSite}\n");
                        }
                        break;
                    case 8:
                        safetyFlag = true;
                        while (safetyFlag == true)
                        {
                            Console.WriteLine("Input index: ");
                            input = Console.ReadLine();
                            try
                            {
                                ind = int.Parse(input);
                                safetyFlag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Caught: {ex.Message}\n");
                                Console.WriteLine($"Type: {ex.TargetSite}\n");
                            }
                        }
                        try
                        {
                            M.Ppls.RemoveAt(ind);
                            Console.WriteLine("Successfully!\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Caught: {ex.Message}\n");
                            Console.WriteLine($"Type: {ex.TargetSite}\n");
                        }
                        safetyFlag = true;
                        break;
                    case 9:
                        safetyFlag = true;
                        while (safetyFlag == true)
                        {
                            Console.WriteLine("Input index: ");
                            input = Console.ReadLine();
                            try
                            {
                                ind = int.Parse(input);
                                safetyFlag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Caught: {ex.Message}\n");
                                Console.WriteLine($"Type: {ex.TargetSite}\n");
                            }
                        }
                        try
                        {
                            M.Docs.RemoveAt(ind);
                            Console.WriteLine("Successfully!\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Caught: {ex.Message}\n");
                            Console.WriteLine($"Type: {ex.TargetSite}\n");
                        }
                        safetyFlag = true;
                        break;
                    case 10:
                        safetyFlag = true;
                        while (safetyFlag == true)
                        {
                            Console.WriteLine("Input dt: ");
                            input = Console.ReadLine();
                            try
                            {
                                dt = int.Parse(input);
                                safetyFlag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Caught: {ex.Message}\n");
                                Console.WriteLine($"Type: {ex.TargetSite}\n");
                            }
                        }
                        M.updateAgentStatus(dt);
                        safetyFlag = true;
                        break;
                    case 11:
                        Console.WriteLine("\nEnd of program execution");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
/*        static void Main(string[] args)
        {
            Menu();
        }
    }
}
*/
