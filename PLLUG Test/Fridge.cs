using System;

namespace PLLUG_Test
{
    public class Fridge: Appliance
    {
        public Fridge(int height, int width, int length) : base(height, width, length) { }
        public override void PrintStatus()
        {
            Console.WriteLine($"{nameof(Fridge)} {(CheckDimensions() ? "fit" : "not fit")}");
        }
    }
}