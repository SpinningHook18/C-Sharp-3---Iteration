using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 mark = 0, total = 0, count = 0;
            double average;
            do
            {
                count = count + 1;
                Console.WriteLine("Enter mark:");
                mark = Convert.ToInt32(Console.ReadLine());
                total = total + mark;
            } while (mark != -1);
            average = total / count;
            Console.WriteLine("The average mark is {0}", average);
            Console.ReadLine();
        }
    }
}
