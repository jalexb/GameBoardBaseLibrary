using System;

namespace CSharpGameDevFoundation
{
    public class Object
    {
        public int X { get; set; } = 50;
        public int Y { get; set; } = 50;
        public string Icon { get; private set; } = " ";

        public Object(int x, int y, string ascii)
        {
            X = x;
            Y = y;
            Icon = ascii;
        }
    }
}