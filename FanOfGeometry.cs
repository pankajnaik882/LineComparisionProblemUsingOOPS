﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblemUsingOOPS
{
    public class FanOfGeometry
    {
        public void fanOfGeometry()
        {

            Console.WriteLine("Enter the x1 co-ordinate");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y1 co-ordinate");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the x2 co-ordinate");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y2 co-ordinate");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The lenght of line using co-ordinate : " + lengthOfLine);

            if (x1 > x2 && y1 > y2)
            {
                Console.WriteLine("X1 and Y1 is greater than X2 and Y2");
            }
            else if (x2 > x1 && y2 > y1)
            {
                Console.WriteLine("X2 And Y2 is greater than X1 and Y1");
            }
            else
            {
                Console.WriteLine("Both Are Equal");
            }
        }
    }
}
