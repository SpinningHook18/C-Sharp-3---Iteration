using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 stars, rows;
            Console.WriteLine("Enter number of stars per row:");
            stars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            for (Int32 i = 0; i <= rows; i = i + 1)
            {
                for (Int32 j = 0; j <= stars; j = j + 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
