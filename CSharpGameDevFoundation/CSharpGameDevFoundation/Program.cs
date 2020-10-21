using System;

namespace CSharpGameDevFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(50, 50);
            window.BorderASCII();
            window.DisplayWindow();

            Console.WriteLine("Hello World!");
        }
    }
}
