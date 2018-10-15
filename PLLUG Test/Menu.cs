using System;
using static PLLUG_Test.Program;

namespace PLLUG_Test
{
    public class Menu
    {
        public static void ShowMenu()
        {
            string buf;
            bool check = false;
            while (true)
            {
                PrintMenuTemplate();
                buf = Console.ReadLine();
                Console.Clear();
                switch (buf)
                {
                    case "1":
                        int doorNum;
                        check = false;
                        Console.WriteLine("Please choose the (1)Rectangle or (2)Round doors: ");
                        while (!check)
                        {
                            if (int.TryParse(Console.ReadLine(), out doorNum))
                            {
                                switch (doorNum)
                                {
                                    case 1:
                                        CheckParams(out int heigth, out int width);
                                        Console.WriteLine("Enter door model:");
                                        Program.Doors.Add(new RectangleDoor(heigth, width, Console.ReadLine()));
                                        check = true;
                                        break;
                                    case 2:
                                        CheckParams(out int diametr);
                                        Console.WriteLine("Enter door model:");
                                        Program.Doors.Add(new RoundDoor(diametr, Console.ReadLine()));
                                        check = true;
                                        break;
                                    default:
                                        Console.WriteLine("Enter correct number!");
                                        break;
                                }
                            }
                        }
                        break;
                    case "2":
                        check = false;
                        while (!check)
                        {
                            Console.WriteLine("Please enter applience type(Fridge ,Cupboard ,Barrel , Ball ): ");
                            switch (Console.ReadLine().ToLower())
                            {
                                case "fridge":
                                    CheckParams(out int frHeigth, out int frWidth, out int frLength);
                                    Console.WriteLine("Enter item name:");
                                    Appliances.Add(new Fridge(frHeigth, frWidth, frLength, Console.ReadLine()));
                                    check = true;
                                    break;
                                case "cupboard":
                                    CheckParams(out int cbHeigth, out int cbWidth, out int cbLength);
                                    Console.WriteLine("Enter item name:");
                                    Appliances.Add(new Cupboard(cbHeigth, cbWidth, cbLength, Console.ReadLine()));
                                    check = true;
                                    break;
                                case "barrel":
                                    CheckParams(out int brHeigth, out int brWidth);
                                    Console.WriteLine("Enter item name:");
                                    Appliances.Add(new Barrel(brHeigth, brWidth, Console.ReadLine()));
                                    check = true;
                                    break;
                                case "ball":
                                    CheckParams(out int diametr);
                                    Console.WriteLine("Enter item name:");
                                    Appliances.Add(new Ball(diametr, Console.ReadLine()));
                                    check = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong type, try again...");
                                    break;
                            }
                        }
                        break;

                    case "3":
                        foreach (Appliance item in Appliances)
                        {
                            foreach (Door door in Doors)
                            {
                                item.PrintStatus(item, door);
                            }
                        }
                        break;


                    case "4":
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Please enter only existing menu option numbers!");
                        break;
                }
            }
        }

        private static void PrintMenuTemplate()
        {
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│1)Create door                      │");
            Console.WriteLine("│2)Create object                    │");
            Console.WriteLine("│3)Check status                     │");
            Console.WriteLine("│4)Exit                             │");
            Console.WriteLine("└───────────────────────────────────┘");
        }
        private static bool ValideRange(int num)
        {
            return num < 400 && num > 0;
        }

        private static void CheckParams(out int diametr)
        {
            Console.WriteLine("Enter diametr:");
            while (!int.TryParse(Console.ReadLine(), out diametr) || !ValideRange(diametr))
            {
                Console.WriteLine("Enter correct number!");
            }
        }

        private static void CheckParams(out int heigth, out int width)
        {
            Console.WriteLine("Enter heigh:");
            while (!int.TryParse(Console.ReadLine(), out heigth) || !ValideRange(heigth))
            {
                Console.WriteLine("Enter correct number!");
            }

            Console.WriteLine("Enter width:");
            while (!int.TryParse(Console.ReadLine(), out width) || !ValideRange(width))
            {
                Console.WriteLine("Enter correct number!");
            }
        }

        private static void CheckParams(out int heigth, out int width, out int length)
        {
            CheckParams(out heigth, out width);

            Console.WriteLine("Enter length:");
            while (!int.TryParse(Console.ReadLine(), out length) || !ValideRange(length))
            {
                Console.WriteLine("Enter correct number!");
            }
        }
    }
}