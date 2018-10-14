using System;
using System.Collections.Generic;

namespace PLLUG_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Door door1 = new RectangleDoor(180, 60);
            Door door2 = new RoundDoor(120);

            List<Appliance> appliances = new List<Appliance>
            {
                    new Fridge(230, 120, 70),
                    new Cupboard(210, 120, 50),
                    new Barrel(220, 100),
                    new Ball(50)
            };

            foreach (Appliance item in appliances)
            {
                item.PrintStatus(item.GetType().Name, door1);
                item.PrintStatus(item.GetType().Name, door2);
            }
                
            Console.ReadLine();
        }
    }
}