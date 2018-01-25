using EqualityInDotNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality in .Net:\n");

            Console.WriteLine("\nUsing Object.Equals: Object type\n");
            //Class instance (Reference equality)
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");
            TestFoodEquality(banana, chocolate);
            TestFoodEquality(banana, banana2);

            //Strings (Value equality)
            Console.WriteLine("\nUsing Object.Equals: value type\n");
            string strBanana = "banana";
            string strBanana2 = string.Copy(strBanana);
            TestFoodEquality(strBanana, strBanana2);
            TestFoodEquality(strBanana, null);

            //Structs (Value equality)
            Console.WriteLine("\nUsing Object.Equals: Object type\n");
            StructFood structBanana = new StructFood("banana");
            StructFood structBanana2 = new StructFood("banana");
            StructFood structChocolate = new StructFood("chocolate");
            TestFoodEquality(structBanana, structChocolate);
            TestFoodEquality(structBanana, structBanana2);

            //Using static method (in comparison to virtual method, this one checks for nulls as well):
            Console.WriteLine("\nUsing static method:\n");
            Console.WriteLine(
                    $"\nStatic method: {object.Equals(banana, banana)}");
            Console.WriteLine(
                    $"\nStatic method: {object.Equals(strBanana, strBanana2)}");
            Console.WriteLine(
                    $"\nStatic method: {object.Equals(banana, strBanana)}");
            Console.WriteLine(
                    $"\nStatic method: {object.Equals(null, strBanana)}");
            Console.WriteLine(
                    $"\nStatic method: {object.Equals(null, null)}");


            //Using static method System.Object.ReferenceEquals
            Console.WriteLine("\nUsing System.Object.ReferenceEquals:\n");
            Console.WriteLine(
                    $"\nStatic method: {object.ReferenceEquals(banana, banana)}");
            Console.WriteLine(
                    $"\nStatic method: {object.ReferenceEquals(banana, banana2)}");
            Console.WriteLine(
                    $"\nStatic method: {object.ReferenceEquals(strBanana, strBanana2)}");
            Console.WriteLine(
                    $"\nStatic method: {object.ReferenceEquals(banana, strBanana)}");
            Console.WriteLine(
                   $"\nStatic method: {object.ReferenceEquals(null, null)}");


            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        private static void TestFoodEquality(object a, object b)
        {
            if (a != null && b != null)
            {
                Console.WriteLine(
                    $"Is {a} of type '{a.GetType().Name}' " +
                    $"equals to {b} of type '{b.GetType().Name}': " +
                    $"{((object)a).Equals((object)b)}");
            }
            else
            {
                Console.WriteLine(
                    $"ERROR: can not do comparison for NULL!!!");
            }

            Console.WriteLine();
        }

        //End of class
    }
}
