using System;

namespace PLLUG_Test
{
    public abstract class Appliance
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }

        public Appliance(int height, int width,int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        protected bool CheckDimensions(Door door)
        {
            if (door.Height > Height && (door.Width > Width || door.Width > Length))
                return true;
            else if (door.Height > Width && door.Width > Length)
                return true;
            return false;
        }

        public void PrintStatus(string name, Door door)
        {
            Console.WriteLine($"{name} {(CheckDimensions(door) ? "fit" : "not fit")} in {door.GetType().Name}");
        }
    }

    public class Fridge : Appliance
    {
        public Fridge(int height, int width, int length) : base(height, width, length) { }
    }

    public class Cupboard : Appliance
    {
        public Cupboard(int height, int width, int length) : base(height, width, length) { }
    }

    public class Barrel : Appliance
    {
        public Barrel(int height, int diametr) : base(height, diametr, diametr) { }
    }

    public class Ball : Appliance
    {
        public Ball(int diametr) : base(diametr, diametr, diametr) { }
    }
}