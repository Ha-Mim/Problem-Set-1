using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparisonApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number =");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number =");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Small Number = {0} ", b);
                Console.ReadLine();
                Console.WriteLine("Large Number = {0}", a);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Small Number = {0}", a);
                Console.ReadLine();
                Console.WriteLine("Large Number = {0}", b);
                Console.ReadLine();
            }
        }
    }
}
