namespace PLLUG_Test
{
    public abstract class Door
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public string Name { get; private set; }

        public Door(int height, int width, string name)
        {
            Height = height;
            Width = width;
            Name = name;
        }
    }
    public class RectangleDoor : Door
    {
        public RectangleDoor(int height, int weight, string name) : base(height, weight, name) { }
    }

    public class RoundDoor : Door
    {
        public RoundDoor(int diametr, string name) : base(diametr, diametr, name) { }
    }
}