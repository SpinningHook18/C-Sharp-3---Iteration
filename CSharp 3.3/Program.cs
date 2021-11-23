using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num, remainder;
            Console.WriteLine("Enter a positive integer less than 256:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                remainder = num % 2;
                Console.WriteLine(remainder);
                num = num / 2;
            }
            Console.ReadLine();

        }
    }
}
