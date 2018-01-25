using EqualityImplementation.Classes;
using EqualityInDotNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality Implementation for Value Type:\n");

            StructFood banana = new StructFood("banana", FoodType.Fruit);
            StructFood banana2 = new StructFood("banana", FoodType.Fruit);
            StructFood chocolate = new StructFood("chocolate", FoodType.Sweets);

            Console.WriteLine($"banana == banana2: {banana == banana2}");
            Console.WriteLine($"banana == chocolate: {banana == chocolate}");
            Console.WriteLine($"banana2 == chocolate: {banana2 == chocolate}");


            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }
    }
}
