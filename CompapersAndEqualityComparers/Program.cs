using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EqualityImplementation.Classes;
using EqualityInDotNet.Classes;

namespace CompapersAndEqualityComparers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compapers and Equality Comparers:\n");

            SampleBasicStringComparison();
            FoodInstancesComparison();


            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        private static void FoodInstancesComparison()
        {
            Food[] list = {
                new Food("apple", FoodType.Fruit),
                new Food("banana", FoodType.Fruit),
                new Food("pear", FoodType.Fruit),
                new Food("apple", FoodType.Fruit),
            };

            Array.Sort(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void SampleBasicStringComparison()
        {
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
        }

        //End of Class
    }
}
