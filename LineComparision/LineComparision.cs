using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class LineComparision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Program");

            double x1, x2, y1, y2, lengthOfLine1, lengthOfLine2;

            Console.WriteLine("Enter x1 co-ordinate of line :");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of line :");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 co-ordinate of line :");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 co-ordinate of line :");
            y2 = Convert.ToDouble(Console.ReadLine());

            lengthOfLine1= Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of first line is:{0}", lengthOfLine1);

            Console.ReadLine();
        }
    }
}
