using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 mark;
            Int32 max;
            max = 100;
            Console.WriteLine("Enter a mark between 0 and {0}", max);
            mark = Convert.ToInt32(Console.ReadLine());
            while (mark < 0 || mark > max)
            {
                Console.WriteLine("Invalid range, enter again:");
                mark = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Valid range");
            Console.ReadLine();
        }
    }
}
