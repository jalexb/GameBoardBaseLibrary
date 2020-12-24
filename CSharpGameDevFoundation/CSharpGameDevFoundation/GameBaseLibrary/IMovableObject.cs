using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGameDevFoundation.GameBaseLibrary
{
    interface IMovableObject
    {
        int NextY { get; set; }
        int CurrY { get; set; }
        int NextX { get; set; }
        int CurrX { get; set; }
        bool Up { get; set; }
        bool Down { get; set; }
        bool Left { get; set; }
        bool right { get; set; }

        public Object Move(string direction);

    }
}