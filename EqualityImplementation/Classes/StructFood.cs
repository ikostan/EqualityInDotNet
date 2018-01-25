using EqualityImplementation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityInDotNet.Classes
{
    public struct StructFood : IEquatable<StructFood>
    {
        private readonly string _name;
        private readonly FoodType _foodType;

        public StructFood(string name, FoodType foodType)
        {
            this._name = name;
            this._foodType = foodType;
        }

        public string Name
        {
            get { return _name; }
        }

        public FoodType FoodType
        {
            get { return _foodType; }
        }

        //'==' operator implementation:
        public static bool operator ==(StructFood a, StructFood b)
        {
            return a.Equals(b);
        }

        //'!=' operator implementation:
        public static bool operator !=(StructFood a, StructFood b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            return (_foodType.GetHashCode() ^ _name.GetHashCode());
        }
        
        public override string ToString()
        {
            return _name;
        }

        public bool Equals(StructFood other)
        {
            // Using '==' in order to compare values and not reference
            return (_name == other._name && 
                    _foodType == other.FoodType);
        }

        public override bool Equals(object obj)
        {
            if (obj is StructFood)
            {
                return Equals((StructFood)obj);
            }
            else
            {
                return false;
            }
        }

        //End of Class
    }
}
