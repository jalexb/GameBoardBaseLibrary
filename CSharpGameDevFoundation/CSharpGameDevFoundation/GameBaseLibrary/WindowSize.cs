using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CSharpGameDevFoundation
{
    class Window
    {
        

        private int Height { get; set; } = 15;
        private int Width { get; set; } = 50;

        public Dictionary<int[], Object> GameBoard = new Dictionary<int[], Object>();
        public Border[,] XYGameWindowReference { get; private set; } //-25, -25 ==> 0,0  25, 25 ==> 49, 49

        private int xPositives = Height / 2;
        private int xNegatives = -(Height / 2);

        int yPositives = Width / 2;
        int yNegatives = -(Width / 2);



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

        
        /// <summary>
        /// Creates the size of the X[] and Y[] and builds objectPosition for each location in the array.
        /// </summary>
        private void BuildGameWindowArray()
        {
            
            Console.SetWindowSize(Width, Height);

            

            for( int i = 0; i <= XYGameWindowReference.GetUpperBound(0); i++ ) // i == x
            {
                for ( int j = 0; j <= XYGameWindowReference.GetUpperBound(1); j++ ) // j == y
                {
                    if (i < yPositives)
                    {
                        if(j < xPositives)
                        {
                            int[] positionXandY = { xNegatives + i, yNegatives + j };
                            GameBoard[positionXandY] = null;
                        }
                        else
                        {
                            int[] positionXandY = { xNegatives + i, yNegatives + j };
                            GameBoard[positionXandY] = null;
                        }
                    }
                    else
                    {
                        if (j > xPositives)
                        {
                            int[] positionXandY = { xNegatives + i, yNegatives + j };
                            GameBoard[positionXandY] = null;
                        }
                        else
                        {
                            int[] positionXandY = { xNegatives + i, yNegatives + j };
                            GameBoard[positionXandY] = null;
                        }
                    }

                    
                }
                
            }
            
        }

       
        /// <summary>
        /// Sets the ascii characters of the border
        /// </summary>
        /// <param name="ascii"></param>
        public void BorderASCII(string ascii = "*")
        {
            for (int i = XYGameWindowReference.GetUpperBound(0); i > 0; i--) //sets the first and last rows to ascii border
            {
                GameBoard[]

                XYGameWindowReference[i - 1, 0].ASCII(ascii); //Bottom
                XYGameWindowReference[i - 1, (Width - 1)].ASCII(ascii); //Top
               
            }
            for (int i = XYGameWindowReference.GetUpperBound(1); i >=0; i--) //sets the first and last columns to ascii border
            {
                XYGameWindowReference[0, i].ASCII(ascii); //Left Side
                XYGameWindowReference[(Height - 1), i].ASCII(ascii); //Right Side
            }

        }
        /// <summary>
        /// Prints the window to the console. Used for testing.
        /// </summary>
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