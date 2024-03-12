using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Hero
    {
        internal string Name { get; set; }
        internal int Health { get; set; }
        internal int Mana { get; set; }
        internal int Coins { get; set; }

        internal Weapon weapon { get; set; }
        internal Armor armor { get; set; }

        internal List<Skill> HeroSkills = new List<Skill>();

        public Hero(string name, Weapon weapon, Armor armor, List<Skill> HeroSkills)
        {
            Name = name;
            Health = 100;
            Mana = 100;
            Coins = 50;

            this.weapon = weapon;
            this.armor = armor;

            this.HeroSkills = HeroSkills;
        }
    }
}
