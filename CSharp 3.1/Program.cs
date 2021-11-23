using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            Int32 num;
            Console.WriteLine("Enter a phrase:");
            phrase = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (Int32 count = 1; count <= num; count = count +1)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();
        }
    }
}
