using System;
using System.Security.Cryptography;

namespace CSharpGameDevFoundation
{
    class Window
    {
        

        private int Height { get; set; } = 15;
        private int Width { get; set; } = 50;

        public Border[,] XYGameWindowReference { get; private set; } //-25, -25 ==> 0,0  25, 25 ==> 49, 49

          


        /// <summary>
        /// Gets X and Y, and creates window size. X and Y must be EVEN
        /// </summary>
        public Window(int x, int y)
        {
            Height = x;
            Width = y;
            BuildGameWindowArray();
        }
        /// <summary>
        /// Overload auto sets it Window Size to 50x50
        /// </summary>
        public Window()
        {
            BuildGameWindowArray();
        }

        //Creates the size of X[] and Y[], and 
        private void BuildGameWindowArray()
        {
            
            Console.SetWindowSize(Width, Height);
            //set x and y to even numbers if they aren't already
            //if (X % 2 != 0)
            //{
            //   X = X/2;
            //}
            //if ( Y % 2 != 0)
            //{
            //    Y = Y;
            //}
            XYGameWindowReference = new Border[Height, Width];
            int xPositives = Height / 2;
            int xNegatives = -(Height / 2);

            int yPositives = Width / 2;
            int yNegatives = -(Width / 2);

            for( int i = 0; i <= XYGameWindowReference.GetUpperBound(0); i++ ) // i == x
            {
                for ( int j = 0; j <= XYGameWindowReference.GetUpperBound(1); j++ ) // j == y
                {
                    Border position;
                    if (i < yPositives)
                    {
                        if(j < xPositives)
                        {
                            position = new Border(xNegatives + i, yNegatives + j);
                            
                        }
                        else
                        {
                            position = new Border(xNegatives + i, yNegatives + j);
                        }
                    }
                    else
                    {
                        if (j > xPositives)
                        {
                            position = new Border(xNegatives + i, yNegatives + j);
                        }
                        else
                        {
                            position = new Border(xNegatives + i, yNegatives + j);
                        }
                    }

                    XYGameWindowReference[i, j] = position;
                }
                
            }
            
        }

        // 0,0 will be the middle of the screen.
        //popualtes first and last row with ascii
        //populates the first and last column in each row with ascii
        //
        /// <summary>
        /// Sets the ascii characters of the border
        /// </summary>
        /// <param name="ascii"></param>
        public void BorderASCII(string ascii = "*")
        {
            for (int i = XYGameWindowReference.GetUpperBound(0); i > 0; i--) //sets the first and last rows to ascii border
            {

                XYGameWindowReference[i - 1, 0].ASCII(ascii); //Bottom
                XYGameWindowReference[i - 1, (Width - 1)].ASCII(ascii); //Top
               
            }
            for (int i = XYGameWindowReference.GetUpperBound(1); i >=0; i--) //sets the first and last columns to ascii border
            {
                XYGameWindowReference[0, i].ASCII(ascii); //Left Side
                XYGameWindowReference[(Height - 1), i].ASCII(ascii); //Right Side
            }

        }
        public void DisplayWindow()
        {

            foreach (Border bo in XYGameWindowReference)
            {
                if (bo.Y < Width / 2)
                {
                    Console.Write(bo.Icon);
                }
                else
                {
                    Console.WriteLine(bo.Icon);
                }
                 
            }
        }
    }
}