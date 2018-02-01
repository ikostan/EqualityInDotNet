using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithHashCodes.Classes;

namespace WorkingWithHashCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compapers and Equality Comparers:\n");

            try
            {
                //
                TestStandartHash();

            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                Console.WriteLine(c.StackTrace);
            }

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        private static void TestStandartHash()
        {
            FoodItem beetroot = new FoodItem("beetroot", FoodType.Vegetables);
            FoodItem pickledBeetroot = new FoodItem("beetroot", FoodType.Sweets);

            var eqComparer = FoodItemEqualityComparer.Instance();
            bool equals = eqComparer.Equals(beetroot, pickledBeetroot);

            Console.WriteLine("Equals? " + equals.ToString());
            Console.WriteLine(eqComparer.GetHashCode(beetroot));
            Console.WriteLine(eqComparer.GetHashCode(pickledBeetroot));
        }

        //End of Class
    }
}
