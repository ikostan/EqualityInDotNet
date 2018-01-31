using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompapersAndEqualityComparers.Classes
{
    public class Food
    {
        private string _name;
        private FoodType _foodType;

        public string Name { get { return _name; } }

        public FoodType FoodType { get => _foodType; }

        public Food(string name, FoodType foodType)
        {
            this._name = name;
            this._foodType = foodType;
            System.Diagnostics.Debug.WriteLine($"_name: {_name}, _foodType: {_foodType}");
        }

        public override string ToString()
        {
            return $"{_name} ({_foodType})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Food fobj = obj as Food;
            return this._name == fobj.Name && this._foodType == fobj._foodType;
        }

        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._foodType.GetHashCode();
        }

        public static bool operator ==(Food x, Food y)
        {
            return object.Equals(x,y);
            //return x.Name == y.Name && x.FoodType == y.FoodType; //Wrong implementation
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
            //return !(x.Name == y.Name && x.FoodType == y.FoodType); //Wrong implementation
        }

        //End of Class
    }
}
