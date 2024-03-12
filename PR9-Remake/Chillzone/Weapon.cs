using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Weapon
    {
        internal string Name { get; set; }
        internal double Damage { get; set; }
        internal int Price { get; set; }

        public Weapon(string name, double damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;
        }

        public Weapon(string name, double damage)
        {
            Name = name;
            Damage = damage;
        }
        public override string ToString()
        {
            return $"{Name} | Урон: {Damage} | Цена: {Price}";
        }
    }
}
