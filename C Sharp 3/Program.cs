using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds, euros;
            Console.WriteLine("Enter number of £:");
            pounds = Convert.ToDouble(Console.ReadLine());
            euros = pounds * 1.35;
            Console.WriteLine("£{0} is equal to €{1}", pounds, euros);
            Console.ReadLine();
        }
    }
}
