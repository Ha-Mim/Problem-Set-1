using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentVariableApp
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            Console.ReadLine();

        }
    }
}
