using EqualityImplementation.Classes;
using EqualityInDotNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityImplementationReferenceType.Classes
{
    public sealed class CookedFood : Food
    {
        private string _cookingMethod;

        public CookedFood(string cookingMethod, string name, FoodType type) : base(name, type)
        {
            this._cookingMethod = cookingMethod;
        }

        public string CookingMethod { get { return _cookingMethod; } }

        public override string ToString()
        {
            return string.Format("{0} {1}", _cookingMethod, base.Name);
        }
    }
}
