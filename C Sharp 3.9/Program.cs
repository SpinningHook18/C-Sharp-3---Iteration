using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 total = 0;
            //for (Int32 i = 0; i <= 100; i = i + 1)
            //{
            //    total = i + total;
            //}
            total = 100 / 2 * (2 * 1 + (100 - 1) * 1);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
