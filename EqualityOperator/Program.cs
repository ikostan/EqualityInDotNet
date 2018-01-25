using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality operator ('==') in C#:\n");

            int x = 1, y = 1;
            equalityOperatorIntegers(x, y);

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        //
        private static void equalityOperatorIntegers(int x, int y)
        {
            Console.WriteLine($"\nCompare between {x} and {y}:");
            Console.WriteLine($"C# 'ReferenceEquals' Method: {ReferenceEquals(x,y)}");
            Console.WriteLine($"C# 'Equals' Method: {x.Equals(y)}");
            Console.WriteLine($"'==' operator: {x == y}");
        }

        //End of Class
    }
}
