using System;

namespace PLLUG_Test
{
    public sealed class Door
    {
        private static readonly Lazy<Door> lazy =  new Lazy<Door>(() => new Door());
        public static Door Instance { get { return lazy.Value; } }

        public const int HEIGHT = 220;
        public const int WIDTH = 80;

        private Door() {}
    }
}