using EqualityImplementation.Classes;
using EqualityImplementationReferenceType.Classes;
using EqualityInDotNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityImplementationReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality Implementation for Reference Type:\n");

            Food apple = new Food("apple", FoodType.Fruit);
            //Console.WriteLine(apple);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodType.Fruit);
            //Console.WriteLine(stewedApple);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodType.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodType.Fruit);
            Food apple2 = new Food("apple", FoodType.Fruit);

            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        //
        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1 == food2)
            {
                Console.WriteLine($"{food1,12} == {food2}");
            }
            else
            {
                Console.WriteLine($"{food1,12} != {food2}");
            }
        }

        //End of Class
    }
}
