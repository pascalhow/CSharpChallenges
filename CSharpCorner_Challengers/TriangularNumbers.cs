using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCorner_Challengers
{
    class TriangularNumbers
    {
        /******************************************************************************************
            Write a program to produce the following output:
            1
            2 3
            4 5 6
            7 8 9 10
         ******************************************************************************************/

        public void triangularNumbers(int numOfiterations)
        {
            int count = 1;   // First number to write is 1 

            for (int i = 0; i < numOfiterations; i++)
            {
                int numOfspaces = i;            //  The number of spaces to insert per line

                while (numOfspaces >= 0)        //  Keep looping as long as we have white spaces to insert
                {
                    Console.Write(count);       //  Write the number

                    if (numOfspaces > 0)
                    {
                        Console.Write(" ");     //  Insert the white spaces
                    }
                    count++;
                    numOfspaces--;
                }
                Console.Write("\n");
            }
        }
    }
}
