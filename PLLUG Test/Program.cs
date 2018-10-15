using System;
using System.Collections.Generic;

namespace PLLUG_Test
{
    public class Program
    {
        public static List<Door> Doors = new List<Door>();
        public static List<Appliance> Appliances = new List<Appliance>();
        static void Main(string[] args)
        {
            Menu.ShowMenu();
            Console.ReadLine();
        }
    }
}