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

        protected bool CheckDimensions()
        {
            if (Door.HEIGHT > Height && (Door.WIDTH > Width || Door.WIDTH > Length))
                return true;
            else if (Door.HEIGHT > Width && Door.WIDTH > Length)
                return true;
            return false;
        }
        
        public abstract void PrintStatus();
    }
}