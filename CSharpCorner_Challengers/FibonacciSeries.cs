using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCorner_Challengers
{
    class FibonacciSeries
    {
        public void PrintFibonacci(int length)
        {
            int prevNum = 0;
            int CurrentNum = 1;
            int temp = 0;

            Console.Write(0 + " "); //  Write first fibonacci number

            //  1 1 2 3 5 8 13 21 34 55 
            //  First fibonacci number is 1
            for (int i = 0; i < length; i++)
            {                
                Console.Write(CurrentNum + " ");
                temp = CurrentNum;  //  Save the old number
                CurrentNum = CurrentNum + prevNum;  //  Calculate next fibonacci number
                prevNum = temp; //  Update the previousNum with the old CurrentNum
            }
        }
    }
}
