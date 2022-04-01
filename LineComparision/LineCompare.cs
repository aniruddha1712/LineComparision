using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class LineCompare
    {
        public static void LineComp(double l1,double l2)
        {
            if(l1 == l2)
            {
                Console.WriteLine("Line1 and Line2 are equal");
            }
            else if (l1 > l2)
            {
                Console.WriteLine("Line1 is Greater than Line2");
            }
            else
                Console.WriteLine("Line1 is smaller than Line2");
        }
    }
}
