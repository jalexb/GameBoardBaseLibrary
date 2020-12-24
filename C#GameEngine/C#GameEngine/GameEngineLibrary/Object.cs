using System;

namespace CSharpGameDevFoundation
{
    public class Object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Icon { get; private set; } = " ";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ascii">The character that it'd </param>
        public Object(int x, int y, string ascii)
        {
            X = x;
            Y = y;
            Icon = ascii;
        }
    }
}