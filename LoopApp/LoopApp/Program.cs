using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;

            for (int i = 1; i<=count;i++)
                Console.WriteLine("{0}",i);
            Console.ReadLine();
        }
    }
}
