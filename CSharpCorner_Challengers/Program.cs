using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCorner_Challengers
{
    class Program
    {
        public enum PROBLEMS
        {
            TRIANGULAR_NUMBERS = 1,
            SAME_STRAIGHT_LINE = 2,
            IDENTITY_MATRIX = 3,
            FIBONACCI_SERIES = 4,
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# challenges!\n");
            Console.WriteLine("List of challenges:");
            Console.WriteLine("1. Triangular Numbers");
            Console.WriteLine("2. Same Straight Line");
            Console.WriteLine("3. Identity Matrix");
            Console.WriteLine("4. Fibonacci Series");
            Console.WriteLine("\nSolve problem number: ");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            switch (problemNumber)
            {
                case ((int)PROBLEMS.TRIANGULAR_NUMBERS):
                    {
                        Console.WriteLine("\n/*****************************************************************");
                        Console.WriteLine("Write a program to produce the following output:");
                        Console.WriteLine("1");
                        Console.WriteLine("2 3");
                        Console.WriteLine("4 5 6");
                        Console.WriteLine("7 8 9 10");
                        Console.WriteLine("*****************************************************************/\n");

                        TriangularNumbers C_triangularNumbers = new TriangularNumbers();

                        Console.Write("Please enter the number of iterations: ");

                        int numOfiterations = Convert.ToInt32(Console.ReadLine());     //  Convert string input to int

                        C_triangularNumbers.triangularNumbers(numOfiterations);
                        Console.ReadKey();
                    }
                    break;

                case ((int)PROBLEMS.SAME_STRAIGHT_LINE):
                    {
                        Console.WriteLine("\n/*****************************************************************");
                        Console.WriteLine("Write a program that takes three points (x1, y1), (x2, y2) and");
                        Console.WriteLine("(x3, y3) from the user and the program will check wheteher or not ");
                        Console.WriteLine("all the three points fall on one straight line.");
                        Console.WriteLine("*****************************************************************/\n");

                        //  Array size is 2 to store x and y
                        double[] point1 = new double[2];
                        double[] point2 = new double[2];
                        double[] point3 = new double[2];

                        Console.Write("Please enter x coordinate for point 1: ");
                        point1[0] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter y coordinate for point 1: ");
                        point1[1] = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter x coordinate for point 2: ");
                        point2[0] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter y coordinate for point 2: ");
                        point2[1] = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter x coordinate for point 3: ");
                        point3[0] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter y coordinate for point 3: ");
                        point3[1] = Convert.ToDouble(Console.ReadLine());

                        SameStraightLine C_samestraightline = new SameStraightLine();
                        bool result = C_samestraightline.isOnStraightLine(point1, point2, point3);

                        Console.WriteLine("Are 3 points on same line? " + result.ToString());
                        Console.ReadKey();
                    }
                    break;

                case ((int)PROBLEMS.IDENTITY_MATRIX):
                    {
                        Console.WriteLine("\n/*****************************************************************");
                        Console.WriteLine("Write a program that prints an identity matrix using a for loop,");
                        Console.WriteLine("in other words takes a value n from the user and shows the identity");
                        Console.WriteLine("table of size n * n.");
                        Console.WriteLine("*****************************************************************/\n");

                        Console.WriteLine("Enter a matrix size: ");
                        int matrixsize = Convert.ToInt32(Console.ReadLine());

                        IdentityMatrix C_identityMatrix = new IdentityMatrix();
                        C_identityMatrix.GetIdentityMatrix(matrixsize);
                        Console.ReadKey();
                    }
                    break;

                case ((int)PROBLEMS.FIBONACCI_SERIES):
                    {
                        Console.WriteLine("\n/*****************************************************************");
                        Console.WriteLine("Write a program that prints the Fibonacci series using a loop.");
                        Console.WriteLine("*****************************************************************/\n");

                        Console.WriteLine("Enter length of series: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.PrintFibonacci(length);
                        Console.ReadKey();
                    }
                    break;

                default:
                    break;
            }
            
        }     
    }
}
