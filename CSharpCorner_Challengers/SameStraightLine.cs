using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCorner_Challengers
{
    class SameStraightLine
    {
        /******************************************************************************************
         * Write a program that takes three points (x1, y1), (x2, y2) and (x3, y3) from the user and 
         * the program will check wheteher or not all the three points fall on one straight line.
         * ****************************************************************************************/

        public bool isOnStraightLine(double[] point1, double[] point2, double[] point3)
        {
            //  For 3 points to be on the same line, they must have the same gradient and share at least a common point
            return (((point2[1] - point1[1]) / (point2[0] - point1[0])) == ((point3[1] - point2[1]) / (point3[0] - point2[0])));
        }
    }
}
