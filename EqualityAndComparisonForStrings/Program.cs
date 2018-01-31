using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityAndComparisonForStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality And Comparison For Strings:\n");

            

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        //
        static void DisplayComparison(string str1, string str2, StringComparison comparison)
        {
            int result = string.Compare(str1, str2, comparison);

            Console.WriteLine(String.Format("{0} {1} {2} ({3}, {4})", str1, GetCompareSymbol(result), str2, result, comparison));
        }

        //
        static string GetCompareSymbol(int result)
        {
            if (result == 0)
            {
                return "==";
            }
            else if ()
            {
                return " < ";
            }
            else
            {
                return " > ";
            }
        }

        //End of Class
    }
}
