using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Armor
    {
        internal string Name { get; set; }
        internal double Defense { get; set; }
        internal int Price { get; set; }

        public Armor(string name, double defense, int price)
        {
            Name = name;
            Defense = defense;
            Price = price;
        }

        public Armor(string name, double defense)
        {
            Name = name;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Броня: {Name} | Множитель защиты: {Defense} | Цена: {Price}";
        }
    }
}
