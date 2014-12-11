using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number =");
            int a = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter a Number =");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("Addition Result = {0}", sum);
            Console.ReadLine();

            if (a > b)
            {
                int sub = a - b;
                Console.WriteLine("Substraction Result = {0}", sub);
                Console.ReadLine();
            }
            else
            {
                int sub = b - a;
                Console.WriteLine("Substraction Result = {0}", sub);
                Console.ReadLine();
            }

            int mul = a*b;
            Console.WriteLine("Multiplication Result = {0}", mul);
            Console.ReadLine();

            if (b == 0)
            {
                Console.WriteLine("Cannot Divide By zero");
                Console.ReadLine();
            }
            else
            {
                double div = a/b;
                Console.WriteLine("Division Result = {0}", div);
                Console.ReadLine();
            }

        }
    }
}
