using System;

namespace CSharpGameDevFoundation
{
    class Window
    {
        

        private int X { get; set; } = 50;
        private int Y { get; set; } = 50;

        public Border[,] XYGameWindowReference { get; private set; } //-25, -25 ==> 0,0  25, 25 ==> 49, 49

          


        /// <summary>
        /// Gets X and Y, and creates window size. X and Y must be EVEN
        /// </summary>
        public Window(int x, int y)
        {
            X = x;
            Y = y;
            BuildGameWindowArray();
        }
        /// <summary>
        /// Overload auto sets it Window Size to 50x50
        /// </summary>
        public Window()
        {
     
        }

        //Creates the size of X[] and Y[], and 
        private void BuildGameWindowArray()
        {
            //set x and y to even numbers if they aren't already
            if (X % 2 != 0)
            {
                X += 1;
            }
            if ( Y % 2 != 0)
            {
                Y += 1;
            }
            XYGameWindowReference = new Border[X, Y];
            int xPositives = X / 2;
            int xNegatives = -(X / 2);

            int yPositives = Y / 2;
            int yNegatives = -(Y / 2);

            for( int i = 0; i <= XYGameWindowReference.GetUpperBound(1); i++ ) // i == y
            {
                for ( int j = 0; j <= XYGameWindowReference.GetUpperBound(0); j++ ) // j == x
                {
                    Border position;
                    if (i < yPositives)
                    {
                        if(j < xPositives)
                        {
                            position = new Border(-j, -i);
                            
                        }
                        else
                        {
                            position = new Border(j, -i);
                        }
                    }
                    else
                    {
                        if (j > xPositives)
                        {
                            position = new Border(j, i);
                        }
                        else
                        {
                            position = new Border(-j, i);
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
        public void BorderASCII(string ascii = "*")
        {
            for (int i = XYGameWindowReference.GetUpperBound(0); i >= 0; i--) //sets the first and last rows to ascii border
            {

                XYGameWindowReference[i, 0].ASCII(ascii); //Bottom
                XYGameWindowReference[i, (Y - 1)].ASCII(ascii); //Top
               
            }
            for (int i = XYGameWindowReference.GetUpperBound(1); i >=0; i--) //sets the first and last columns to ascii border
            {
                XYGameWindowReference[0, i].ASCII(ascii); //Left Side
                XYGameWindowReference[(X - 1), i].ASCII(ascii); //Right Side
            }

        }
        public void DisplayWindow()
        {
            foreach (Border b in XYGameWindowReference)
            {
                int i = 1;
                
                while (i % 50 != 0)
                {
                    Console.Write(b.Icon);
                    i++;
                }
            }
        }
    }
}