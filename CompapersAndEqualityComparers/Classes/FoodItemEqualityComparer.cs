using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers.Classes
{
    class FoodItemEqualityComparer : IEqualityComparer<FoodItem>
    {
        private static FoodItemEqualityComparer foodItemEqualityComparer;

        //
        private FoodItemEqualityComparer(){}

        //
        public static FoodItemEqualityComparer Instance()
        {
            if (foodItemEqualityComparer == null)
            {
                foodItemEqualityComparer = new FoodItemEqualityComparer();
            }

            return foodItemEqualityComparer;
        }

        //
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
