using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name =");
            string Name = Console.ReadLine();
            Console.WriteLine("Hi {0} Good Day", Name);
            Console.ReadLine();

        }
    }
}
