using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithHashCodes.Classes
{
    public struct FoodItem : IEquatable<FoodItem>
    {
        private string _name;
        private FoodType _foodType;

        //
        public string Name { get { return _name; } }

        //
        public FoodType FoodType { get => _foodType; }

        //
        public FoodItem(string name, FoodType foodType)
        {
            this._name = name;
            this._foodType = foodType;
            System.Diagnostics.Debug.WriteLine($"_name: {_name}, _foodType: {_foodType}");
        }

        //
        public override string ToString()
        {
            return $"{_name} ({_foodType})";
        }

        //
        public override int GetHashCode()
        {
            return this._foodType.GetHashCode() ^ this._name.GetHashCode();
        }

        //
        public bool Equals(FoodItem other)
        {
            return (
                string.Equals(this.Name, other.Name) && 
                this._foodType == other._foodType);
        }

        //End of Class
    }
}
