using System;
using System.Threading;
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

            //
            string str1 = "apple";
            string str2 = "PINEAPPLE";
            string str3 = "Apple";

            //
            string str4 = "Stra\u00dfe";
            string str5 = "Strasse";

            //
            string str6 = "erkl\u00e4ren";
            string str7 = "erkla\u0308ren";

            //DisplayComparison(str1, str2, StringComparison.CurrentCultureIgnoreCase);
            DisplayAllComparisons(str1, str2);
            DisplayAllComparisons(str1, str3);
            DisplayAllComparisons(str4, str5);
            DisplayAllComparisons(str6, str7);

            Console.WriteLine("\nPlease enter any key to exit...");
            Console.ReadKey();
        }

        //
        static void DisplayAllComparisons(string str1, string str2)
        {
            Console.WriteLine("\nCurrent culture is: " + Thread.CurrentThread.CurrentUICulture);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.Ordinal);
            DisplayComparison(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.InvariantCulture);
            DisplayComparison(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.CurrentCulture);
            DisplayComparison(str1, str2, StringComparison.CurrentCultureIgnoreCase);
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
            else if (result < 0)
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
