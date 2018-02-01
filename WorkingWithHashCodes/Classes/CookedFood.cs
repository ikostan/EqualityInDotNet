using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkingWithHashCodes.Classes
{
    public sealed class CookedFood : Food, IEquatable<CookedFood>
    {
        private string _cookingMethod;

        //
        public CookedFood(string cookingMethod, string name, FoodType type) : base(name, type)
        {
            this._cookingMethod = cookingMethod;
        }

        //
        public static bool operator ==(CookedFood a, CookedFood b)
        {
            return a.Equals(b);
        }

        //
        public static bool operator !=(CookedFood a, CookedFood b)
        {
            return !a.Equals(b);
        }

        //
        public string CookingMethod { get { return _cookingMethod; } }

        //
        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", _cookingMethod, base.Name, this.FoodType);
        }

        //
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
            {
                return false;
            }

            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        //
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        // IEquatable<CookedFood>
        public bool Equals(CookedFood other)
        {
            if (!base.Equals(other))
            {
                return false;
            }

            return this._cookingMethod == other._cookingMethod;
        }

        //End of Class
    }
}
