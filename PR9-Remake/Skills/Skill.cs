using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Skill
    {
        internal string Name { get; }
        internal double Damage { get; }
        internal int Mana { get; }
        internal int Price { get; set; }

        internal double AddDefense { get; }
        internal double AddDamage { get; }
        internal int AddHealth { get; }

        public Skill(string name, int addHealth, int mana, int price)
        {
            Name = name;
            AddHealth = addHealth;
            Mana = mana;
            Price = price;
        }

        public Skill(string name, double damage, int mana, int price)    
        {
            Name = name;
            Damage = damage;
            Mana = mana;
            Price = price;
        }

    }
}
