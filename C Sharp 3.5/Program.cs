using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            Console.WriteLine("Enter the password:");
            pass = Console.ReadLine();
            while (pass != "hi")
            {
                Console.WriteLine("Incorrect password, try again");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Correct!");
            Console.ReadLine();
        }
    }
}
