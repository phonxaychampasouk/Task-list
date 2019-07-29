using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Week4InClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // PrintOutListInItemMenu();
            UserInterface();



        }








        static void UserInterface()
        {

            while (true)
            {
                TopOfMenu();
                {
                    string i = Console.ReadLine();
                    Console.Clear();
                    switch (i)
                    {

                        case "1":
                            {
                                Console.Clear();
                                PrintOutList();
                                break;
                            }
                        case "2":
                            {
                                Console.Clear();
                                SelectTask();
                                ItemMenu();
                                break;
                            }
                        case "3":
                            {
                                Console.Clear();
                                AddTask();
                                break;
                            }
                        case "4":
                            {
                                Console.Clear();
                                UserInterface();
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("Please type correct menu search: ");
                                break;
                            }
                    }

                }
            }

        }

        static void TopOfMenu()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                                Task List                                  ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(" menu buttons");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(String.Format("|{0,-5} | {1,-5} |", "1 - Printout List", " 2 - Select Task"));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(String.Format("|{0,-5} | {1,-5} |", "3 - Add to Task  ", " 4 - GoodBye    "));
            Console.WriteLine("---------------------------------------");


            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        PrintOutList();
                        TopOfMenu();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        SelectTask();
                        ItemMenu();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        AddTask();
                        TopOfMenu();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        TopOfMenu();
                        break;


                    }

            }

        }

        static void PrintOutList() //Add motiple pages Page information
        {
            Console.WriteLine("N = next,    b = back    Esc = go back to menu");
            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            Console.WriteLine("-------------------------------");

            //do
            //               {
            //                   line = sr.ReadLine();
            //                   Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));// Console.WriteLine(i + ". " + line);
            //                   i++;

            //               } while (i != 2);

            String line;
            // line = what contant on the line i represents
            {
                StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt");
                int i = 1;
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));
                    i++;

                } while (i < 21);

                sr.Close();

                ConsoleKeyInfo cki;
                /* local variable definition */
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            PrintOutList3();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.Clear();

                            ItemMenu();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            AddTask();
                            TopOfMenu();
                            break;
                        }
                    default:
                        {

                            Console.Clear();
                            TopOfMenu();
                            break;
                        }

                }


            }
        }
        static void PrintOutList1()

        {
            
            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            Console.WriteLine("-------------------------------");
            String line;

            {
                StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt");
                //line = sr.ReadLine();
                int i = 1;
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));
                    i++;

                } while (i > 0 && i <= 60);

                sr.Close();
   
            }
        }

        static void PrintOutList2()

        {
            Console.WriteLine("N = next,    b = back    Esc = go back to menu");
            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            Console.WriteLine("-------------------------------");
            String line;

            {
                StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt");
                //line = sr.ReadLine();
                int i = 21;
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));
                    i++;

                } while (i <= 20 && i >= 40);

                sr.Close();

                ConsoleKeyInfo cki;
                /* local variable definition */
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            PrintOutList3();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.Clear();
                            PrintOutList();
                            ItemMenu();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            TopOfMenu();
                            break;
                        }



                }



            }
        }

        static void PrintOutList3() // add page numbers

        {
            Console.WriteLine("N = next,    b = back    Esc = go back to menu");
            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            Console.WriteLine("-------------------------------");
            String line;

            {
                StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt");
                //line = sr.ReadLine();
                int i = 21;
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today)); i++;//needs to shown corresponding item to #

                } while (i >= 21 && i <= 40);

                sr.Close();

                ConsoleKeyInfo cki;
                /* local variable definition */
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            PrintOutList4();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.Clear();
                            PrintOutList();
                            //ItemMenu();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            TopOfMenu();
                            break;
                        }



                }
            }
        }
        static void PrintOutList4()
        {
            Console.WriteLine("N = next; b = back");
            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            Console.WriteLine("-------------------------------");
            String line;

            {

                StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt");
                //line = sr.ReadLine();
                int i = 40;
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));
                    i++;
                } while (i > 39 && i < 60);

                sr.Close();

                ConsoleKeyInfo cki;
                /* local variable definition */
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            PrintOutList4();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.Clear();
                            PrintOutList3();
                            ItemMenu();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            TopOfMenu();
                            break;
                        }



                }
            }


            //static void TopOfMenu()
            //{
            //    Console.WriteLine("---------------------------------------------------------------------------");
            //    Console.WriteLine("                                Task List                                  ");
            //    Console.WriteLine("----------------------------------------------------------------------------");
            //    Console.WriteLine(" menu buttons");
            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine(String.Format("|{0,-5} | {1,-5} |", "1 - Printout List", " 2 - Select Task"));
            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine(String.Format("|{0,-5} | {1,-5} |", "3 - Add to Task  ", " 4 - GoodBye    "));
            //    Console.WriteLine("---------------------------------------");


            //    ConsoleKeyInfo cki;
            //    cki = Console.ReadKey(true);
            //    switch (cki.Key)
            //    {
            //        case ConsoleKey.D1:
            //            {
            //                Console.Clear();
            //                PrintOutList();
            //                TopOfMenu();
            //                break;
            //            }
            //        case ConsoleKey.D2:
            //            {
            //                Console.Clear();
            //                SelectTask();
            //                ItemMenu();
            //                break;
            //            }
            //        case ConsoleKey.D3:
            //            {
            //                Console.Clear();
            //                AddTask();
            //                TopOfMenu();
            //                break;
            //            }
            //        case ConsoleKey.D4:
            //            {
            //                Console.Clear();
            //                UserInterface();
            //                TopOfMenu();
            //                break;
            //            }


            //    }

            //}



            //static void PrintOutList() //Add Page information
            //{
            //    Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", " #", "Task", "Date"));
            //    Console.WriteLine("-------------------------------");


            //    String line;

            //    {
            //        StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\bin\\Debug\\netcoreapp2.2\\testweek4project.txt");
            //        //line = sr.ReadLine();
            //        int i = 1;
            //        do
            //        {
            //            line = sr.ReadLine();
            //            Console.WriteLine(String.Format("{0,-2} | {1,-5} | {2,5}", i, line, DateTime.Today));// Console.WriteLine(i + ". " + line);
            //            i++;

            //        } while (line != null);
            //        Console.WriteLine("\n" + "Press [ENTER] to return to menu.");
            //        sr.Close();
            //        Console.ReadLine();
            //        Console.Clear();

            //    }
            //}









            //static void PrintOutListInItemMenu()
            //{

            //    String line;

            //    {
            //        StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\bin\\Debug\\netcoreapp2.2\\testweek4project.txt");
            //        //line = sr.ReadLine();
            //        line = sr.ReadLine();
            //        Console.WriteLine(line);









            //    }
            //}




            //static void PrintOutList2() // add page numbers

            //{

            //    String line;

            //    {
            //        StreamReader sr = new StreamReader("C:\\Users\\pc\\Desktop\\Week4InClassProject\\bin\\Debug\\netcoreapp2.2\\testweek4project.txt");
            //        //line = sr.ReadLine();
            //        int i = 1;
            //        do
            //        {
            //            line = sr.ReadLine();
            //            Console.WriteLine(i + "." + line);
            //            i++;

            //        } while (line != null);

            //        sr.Close();



            //    }
            //}





        }

            static void SelectTask()
        {
            PrintOutList1();                                                 //displays list to choose which item to change
            Console.WriteLine("Which task would you like to access?");

            int itemSelection = Convert.ToInt32(Console.ReadLine());
            string filename = "C:\\Users\\pc\\Desktop\\Week4InClassProject\\testweek4project.txt";

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                Console.Clear();
                Console.Write(lines[itemSelection - 1] + " is selected. What do you want to do with the selected task?");
                //need to add color changing menus. 
                //1. put new item to top of list
                //




            }

        }

        static void ItemMenu() // is going to be used to highlight = doing right now, cross out= done, red= to bottom of list
        {

            Console.WriteLine("\n 1: hightlight as current task" + "\n" + "2. Task is completed" + "\n" + "3. Cross out " + "\n");
            string i = Console.ReadLine();
            switch (i)
            {

                case "1":
                    {




                        Console.Clear();
                        PrintOutList();

                        break;
                    }
                case "2":
                    {




                        break;
                    }


                case "3":
                    {
                        Console.Clear();

                        break;
                    }

                case "4":
                    {
                        Console.Clear();
                        UserInterface();
                        break;

                    }

                default:
                    {
                        System.Console.WriteLine("Please type correct menu search: ");
                        break;
                    }





            }

        }










        static void AddTask()
        {

            Console.WriteLine("To save enter save");

            Console.WriteLine("Please enter items to your to do list: ");
            List<string> list1 = new List<string>();
            string inputForList;
            int i = 1;
            //for (int i = 0; i < 60; i++)
            using (StreamWriter writer = new StreamWriter("testweek4project.txt", true))


                do
                {
                    Console.Write($"  ");
                    inputForList = Console.ReadLine();
                    //if (int.TryParse(inputForList, out value)) ;
                    list1.Add(inputForList);
                    i++;
                    writer.WriteLine(inputForList);

                }

                while (inputForList != "save");
            Console.Clear();

        }

        //static void keys()
        //{
        //    ConsoleKeyInfo cki;
        //    // Prevent example from ending if CTL+C is pressed.
        //    Console.TreatControlCAsInput = false;

        //    do
        //    {
        //        cki = Console.ReadKey();

        //        Console.WriteLine(cki.Key.ToString());
        //    } while (cki.Key != ConsoleKey.Escape); //sitting and waitng for escapr
        //}
    }
}





















