using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparison (<, <=, >=, >) in .Net:\n");

            string apple = "apple";
            string pear = "pear";

            Console.WriteLine($"apple vs pear: { apple.CompareTo(pear) }");
            Console.WriteLine($"pear vs apple: { pear.CompareTo(apple) }");
            Console.WriteLine($"apple vs apple: { apple.CompareTo(apple) }");

            Console.WriteLine();

            DisplayOrder<string>(apple, pear);
            DisplayOrder<string>(pear, apple);
            DisplayOrder<string>(apple, apple);

            Console.WriteLine();

            DisplayOrder<int>(3, 4);
            DisplayOrder<int>(4, 3);
            DisplayOrder<int>(3, 3);

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        private static void DisplayOrder<T>(T a, T b) where T : IComparable<T>
        {
            int i = a.CompareTo(b);

            if (i == 0)
            {
                Console.WriteLine($"{a} == {b}");
            }
            else if(i > 0)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else
            {
                Console.WriteLine($"{a} < {b}");
            }
        }

        //End of Class
    }
}
