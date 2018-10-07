using System;
using System.Collections.Generic;

namespace PLLUG_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Appliance> appliances = new List<Appliance>
            {
                    new Fridge(230, 90, 50),
                    new Fridge(230, 50, 100),
                    new Cupboard(210,120,50)
            };

            foreach (Appliance item in appliances) item.PrintStatus();
            
            Console.ReadLine();
        }
    }
}