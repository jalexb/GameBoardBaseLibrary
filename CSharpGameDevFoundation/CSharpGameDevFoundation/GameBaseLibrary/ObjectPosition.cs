using System;

namespace CSharpGameDevFoundation
{
    class Border
    {
        public int X { get; set; } = 50;
        public int Y { get; set; } = 50;


        public string Icon { get; private set; } = " ";
        public Border(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ASCII(string ascii)
        {
            Icon = ascii;
        }
        
    }
}