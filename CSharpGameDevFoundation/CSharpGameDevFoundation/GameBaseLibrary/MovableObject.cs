using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGameDevFoundation.GameBaseLibrary
{
    public class MovableObject : Object, IMovableObject

    {
        public int NextY { get; set; }
        public int CurrY { get; set; }
        public int NextX { get; set; }
        public int CurrX { get; set; }
        public bool Up { get; set; } = false;
        public bool Down { get; set; } = false;
        public bool Left { get; set; } = false;
        public bool right { get; set; } = false;

        public MovableObject(int x, int y, string ascii) : base(x, y, ascii) 
        {
            CurrY = y;
            CurrX = x;
        }

        public Object Move(string direction = "up")
        {

            
        }
    }
}
