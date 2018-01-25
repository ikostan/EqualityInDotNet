using EqualityImplementation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityInDotNet.Classes
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
            this._foodType = FoodType;
        }

        public override string ToString(){return _name;}
    }
}
