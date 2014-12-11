using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Lower Limit =");
            int low = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Upper Limit =");
            int up = Convert.ToInt32(Console.ReadLine());

            for(int i=low;i<=up;i++)
            Console.WriteLine("{0}", i);
            Console.ReadLine();

        }
    }
}
