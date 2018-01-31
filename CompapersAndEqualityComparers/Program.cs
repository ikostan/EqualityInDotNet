using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compapers and Equality Comparers:\n");

            string[] list = {
                "orange",
                "banana",
                "pear",
                "apple"
            };

            Array.Sort(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }
    }
}
