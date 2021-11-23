using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 n, total = 1;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (Int32 i = 1; i <= n; i = i + 1)
            {
                total = total * i;
            }
            Console.WriteLine("{0}! = {1}", n, total);
            Console.ReadLine();
        }
    }
}
