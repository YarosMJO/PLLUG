using System;

namespace PLLUG_Test
{
    public abstract class Appliance
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public string Name { get; private set; }

        public Appliance(int height, int width,int length, string name)
        {
            Height = height;
            Width = width;
            Length = length;
            Name = name;
        }

        protected bool CheckDimensions(Door door)
        {
            if (door.Height > Height && (door.Width > Width || door.Width > Length))
                return true;
            else if (door.Height > Width && door.Width > Length)
                return true;
            return false;
        }

        public void PrintStatus(Appliance item, Door door)
        {
            Console.WriteLine($"{item.Name}({item.GetType().Name}) {(CheckDimensions(door) ? "fit" : "not fit")} in {door.Name}({door.GetType().Name})");
        }
    }

    public class Fridge : Appliance
    {
        public Fridge(int height, int width, int length, string name) : base(height, width, length, name) { }
    }

    public class Cupboard : Appliance
    {
        public Cupboard(int height, int width, int length, string name) : base(height, width, length, name) { }
    }

    public class Barrel : Appliance
    {
        public Barrel(int height, int diametr, string name) : base(height, diametr, diametr, name) { }
    }

    public class Ball : Appliance
    {
        public Ball(int diametr, string name) : base(diametr, diametr, diametr, name) { }
    }
}