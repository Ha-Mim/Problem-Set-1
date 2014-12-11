using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             
            int a = 0;
            int b = 1;

            /* 0 1 1 2 3 5 8 13 21 */

           while(a < 100){
               Console.WriteLine(+a);
               
               int temp = a ;
               a = b;
               b = temp + a;
           }

            Console.ReadKey();

        }
    }
}