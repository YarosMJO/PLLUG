using System;

namespace PLLUG_Test
{
    public class Cupboard : Appliance
    {
        public Cupboard(int height, int width, int length) : base(height, width, length) { }
        public override void PrintStatus()
        {
            Console.WriteLine($"{nameof(Cupboard)} {(CheckDimensions() ? "fit" : "not fit")}");
        }
    }
}