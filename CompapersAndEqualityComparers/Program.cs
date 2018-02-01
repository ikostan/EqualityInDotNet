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
                //FoodInstancesComparison();
                //CookedFoodInstancesComparison();
                SampleEqualityComparer();
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
        private static void SampleEqualityComparer()
        {
            var list = new HashSet<FoodItem>();

            list.Add(new FoodItem("banana", FoodType.Fruit));
            list.Add(new FoodItem("orange", FoodType.Fruit));
            list.Add(new FoodItem("Apple", FoodType.Fruit));
            list.Add(new FoodItem("apple", FoodType.Fruit));
            list.Add(new FoodItem("banana", FoodType.Fruit));
            list.Add(new FoodItem("pear", FoodType.Fruit));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //        private static void FoodInstancesComparison()
        private static void CookedFoodInstancesComparison()
        {
            Food[] list =
            {
                new Food("apple", FoodType.Fruit),
                new Food("orange", FoodType.Fruit),
                new Food("banana", FoodType.Fruit),
                new CookedFood("baked", "apple", FoodType.Fruit),
                new Food("pear", FoodType.Fruit)
            };

            SortAndShowList(list);

            Console.WriteLine();

            Food[] list2 =
            {
                new CookedFood("baked", "apple", FoodType.Fruit),
                new Food("orange", FoodType.Fruit),
                new Food("apple", FoodType.Fruit),
                new Food("banana", FoodType.Fruit),
                new Food("pear", FoodType.Fruit)
            };

            SortAndShowList(list2);
        }

        //
        static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instanse());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //
        private static void FoodInstancesComparison()
        {
            Food[] list =
            {
                new Food("orange", FoodType.Fruit),
                new Food("banana", FoodType.Fruit),
                new Food("pear", FoodType.Fruit),
                new Food("apple", FoodType.Fruit),
            };

            Array.Sort(list, FoodNameComparer.Instanse());

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
