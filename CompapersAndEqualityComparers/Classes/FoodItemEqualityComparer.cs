using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers.Classes
{
    class FoodItemEqualityComparer : IEqualityComparer<FoodItem>
    {
        public bool Equals(FoodItem x, FoodItem y)
        {
            return (
                string.Equals(x.Name.ToLower(), y.Name.ToLower()) &&
                x.FoodType == y.FoodType);
        }

        //
        public int GetHashCode(FoodItem obj)
        {
            return obj.Name.ToLower().GetHashCode() ^ obj.FoodType.GetHashCode();
        }

        //End of Class
    }
}
