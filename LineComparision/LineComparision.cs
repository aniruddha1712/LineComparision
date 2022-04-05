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

            LineCoordinate firstLine = new LineCoordinate();
            LineCoordinate secondLine = new LineCoordinate();
            

            Console.WriteLine("For Line:1");
            firstLine.Coordinate();
            double lengthOfLine1 = firstLine.GetLength();
            Console.WriteLine("Length of line1 is {0}", lengthOfLine1);

            Console.WriteLine("For Line:2");
            secondLine.Coordinate();
            double lengthOfLine2 = secondLine.GetLength();
            Console.WriteLine("Length of line2 is {0}",lengthOfLine2);

            LineCompare.LineComp(lengthOfLine1, lengthOfLine2);

            Console.WriteLine(lengthOfLine1.CompareTo(lengthOfLine2));
            Console.ReadLine();
        }
    }
}
