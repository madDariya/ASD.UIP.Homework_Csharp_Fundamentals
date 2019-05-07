using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD.UIP.HW1.VariablesTypesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK1");
            double rectangleSideA = 23.5;
            double rectangleSideB = 14.9;
            double rectangleSquare = rectangleSideA * rectangleSideB;
            double rectanglePerimetr = 2 * rectangleSideA + 2 * rectangleSideB;
            Console.WriteLine("Rectangle side A = " + rectangleSideA);
            Console.WriteLine("Rectangle side B = " + rectangleSideB);
            Console.WriteLine("Square is = " + rectangleSquare);
            Console.WriteLine("Perimetr = " + rectanglePerimetr);
            Console.WriteLine("_________________________________________________");

            Console.WriteLine("TASK2");
            double circleRadius = 13.3;
            const double pi = 3.14;
            double circleLength = 2 * pi * circleRadius;
            double circleSquare = pi * Math.Pow(circleRadius, 2);
            Console.WriteLine("Circle radius is = " + circleRadius);
            Console.WriteLine("Square is = " + circleSquare);
            Console.WriteLine("Length is = " + circleLength);
 
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK3");
            double numberA = 92;
            double numberB = 12;
            double averageAB = (numberA + numberB) / 2;
            Console.WriteLine("Number A = " + numberA);
            Console.WriteLine("Number B = " + numberB);
            Console.WriteLine("The average is = " + averageAB);

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK4");
            double squareRootAB = Math.Sqrt(numberA * numberB); //using variables from task3
            Console.WriteLine("Number A = " + numberA);
            Console.WriteLine("Number B = " + numberB);
            Console.WriteLine("The square root is = " + squareRootAB);

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK5");
            double pointX1 = 19.3;
            double pointX2 = -12;
            double distanceX1X2 = Math.Abs(pointX2 - pointX1);
            Console.WriteLine("Point X1= " + pointX1);
            Console.WriteLine("Point X2 = " + pointX2);
            Console.WriteLine("The distance between X1 and X2  on numeric line " +
                "= |X2 - X1| = " + distanceX1X2);

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK6");
            double Vertex1X = 1;
            double Vertex1Y = 4;
            double Vertex2X = 9;
            double Vertex2Y = -7;
            double RectSideX = Math.Abs(Vertex1X - Vertex2X);
            double RectSideY = Math.Abs(Vertex1Y - Vertex2Y);
            double RectSquare = RectSideX * RectSideY;
            double RectPerimetr = 2 * RectSideX + 2 * RectSideY;
            Console.WriteLine("Point X1= " + Vertex1X);
            Console.WriteLine("Point X2 = " + Vertex2X);
            Console.WriteLine("Rectangle side X = |X2 - X1| = " + RectSideX);
            Console.WriteLine("Point Y1= " + Vertex1Y);
            Console.WriteLine("Point Y2 = " + Vertex2Y);
            Console.WriteLine("Rectangle side Y = |Y2 - Y1| = " + RectSideY);
            Console.WriteLine("Square is = " + RectSquare);
            Console.WriteLine("Perimetr = " + RectPerimetr);

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("TASK7");
            double a = 1;
            double b = 2;
            double c = 3;
            Console.WriteLine("Original values: a = " + a + ", b = " + b + ", c = " + c);
            double temp;
            temp = a;
            a = c;
            c = b;
            b = temp;
            Console.WriteLine("Checking modified values where we expect a = c, b = a, c = b: ");
            Console.WriteLine(" a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine("_________________________________________________");
            Console.Read();
        }
    }
}
