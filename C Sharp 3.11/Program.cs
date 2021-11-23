using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            Console.WriteLine("What number do you want it to go up to: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (Int32 i = 1; i <= num; i = i + 1)
            {
                Console.Write("{0} ", i);
                for (Int32 j = 1; j <= num; j = j + 1)
                {
                    
                    Console.Write("{0} ", (i * j).ToString("00"));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
