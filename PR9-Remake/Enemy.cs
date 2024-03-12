using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Enemy
    {
        internal string Name { get; set; }
        internal int Health { get; set; }
        internal Weapon weapon { get; set; }
        internal Armor armor { get; set; }

        public Enemy(string name, int health, Weapon weapon, Armor armor)
        {
            Name = name;
            Health = health;
            this.weapon = weapon;
            this.armor = armor;
        }
    }
}
