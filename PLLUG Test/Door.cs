namespace PLLUG_Test
{
    public abstract class Door
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public Door(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
    public class RectangleDoor : Door
    {
        public RectangleDoor(int height, int weight) : base(height, weight) { }
    }

    public class RoundDoor : Door
    {
        public RoundDoor(int diametr) : base(diametr, diametr) { }
    }
}