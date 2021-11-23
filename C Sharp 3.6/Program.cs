using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            string again;
            do
            {
                Console.WriteLine("Enter which times table:");
                num = Convert.ToInt32(Console.ReadLine());
                for (Int32 i = 1; i <= 10; i = i + 1)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, num, (i * num));
                }
                Console.WriteLine("Would you like another times table?:");
                again = Console.ReadLine();
            } while (again.ToLower() == "yes");
            Console.ReadLine();
        }
    }
}
