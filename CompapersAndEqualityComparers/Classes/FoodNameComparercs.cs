using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers.Classes
{
    class FoodNameComparer : Comparer<Food>
    {
        private static FoodNameComparer _foodNameComparer;

        private FoodNameComparer() { }

        public static FoodNameComparer Instanse()
        {
            if (_foodNameComparer == null)
            {
                _foodNameComparer = new FoodNameComparer();
            }

            return _foodNameComparer;
        }

        public override int Compare(Food x, Food y)
        {
            if (x != null && y != null)
            {
                return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            }
            else
            {
                if (x == null && y == null)
                {
                    return 0;
                }
                else if (x == null)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        //End of Class
    }
}
