using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class LineCoordinate
    {
        double x1, x2, y1, y2;
        public void Coordinate()
        {
            Console.WriteLine("Enter x1 co-ordinate of line :");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of line :");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 co-ordinate of line :");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 co-ordinate of line :");
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public double GetLength()
        {
            double lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lengthOfLine;
        }


            
    }
}
