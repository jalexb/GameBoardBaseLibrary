using System;

namespace CSharpGameDevFoundation
{
    class Border
    {
        public int X { get; set; } = 50;
        public int Y { get; set; } = 50;

        private string _icon = " ";
        public string Icon
        {
            get
            {
                return _icon;
            }
        }
        public Border(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ASCII(string ascii)
        {
            _icon = ascii;
        }
        
    }
}