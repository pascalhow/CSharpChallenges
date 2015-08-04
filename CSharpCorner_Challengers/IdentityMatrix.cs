using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCorner_Challengers
{
    class IdentityMatrix
    {
        /******************************************************************************************
         * Write a program that prints an identity matrix using a for loop, in other words takes a
         * value n from the user and shows the identity table of size n * n.
         * ****************************************************************************************/
        public void GetIdentityMatrix(int n)
        {
            Console.WriteLine("Identity matrix of " + n.ToString() + " x " + n.ToString() + " size is:\n");

            for (int i = n; i > 0; i--)
            {
                //  Shift 1 to the left by (i -1) times and convert to binary
                //  Pad according to n size matrix
                string s = Convert.ToString(1<<(i - 1), 2).PadLeft(n, '0');              
                Console.WriteLine(s);
            }
        }
    }
}
