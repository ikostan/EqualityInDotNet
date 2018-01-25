using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityInDotNet.Classes
{
    public struct StructFood
    {
        private string _name;
        public string Name { get { return _name; } }
        public StructFood(string name) { this._name = name; }
        public override string ToString(){return _name;}
    }
}
