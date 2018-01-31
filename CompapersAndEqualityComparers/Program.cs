using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompapersAndEqualityComparers.Classes;


namespace CompapersAndEqualityComparers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compapers and Equality Comparers:\n");

            try
            {
                //SampleBasicStringComparison();
                FoodInstancesComparison();
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                Console.WriteLine(c.StackTrace);
            }


            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        //
        private static void FoodInstancesComparison()
        {
            Food[] list = {
                new Food("orange", FoodType.Fruit),
                new Food("banana", FoodType.Fruit),
                new Food("pear", FoodType.Fruit),
                new Food("apple", FoodType.Fruit),
            };

            Array.Sort(list, new FoodNameComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //
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
