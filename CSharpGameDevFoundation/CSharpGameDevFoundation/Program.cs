﻿using System;

namespace CSharpGameDevFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(35, 75, "*");
            Object snakeHead = new Object(0, 0, "o");
            window.AddObject(snakeHead);
            window.Refresh();
            Console.ReadLine();
        }
    }
}
