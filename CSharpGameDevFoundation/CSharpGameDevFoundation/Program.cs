using System;

namespace CSharpGameDevFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            window.BorderASCII();
            window.DisplayWindow();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
