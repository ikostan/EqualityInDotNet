using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers.Classes
{
    class FoodNameComparer : IComparer<Food>
    {
        public int Compare(Food x, Food y)
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
