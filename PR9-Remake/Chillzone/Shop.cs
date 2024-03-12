using PR9.Skills;
using PR9_Remake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Shop
    {
        GameSkills gameSkills = new GameSkills();

        internal Armor[] armors { get; set; }
        internal Weapon[] weapons { get; set; }
        public Shop()
        {
            AddItems();
        }
        internal void AddItems()
        {
            armors = new Armor[]
            {
                new Armor("Кожаная броня", 1.1, 10),
                new Armor("Железная броня", 1.25, 55)
            };

            weapons = new Weapon[]
            {
                new Weapon("Магический посох", 10, 10),
                new Weapon("Железный меч", 10 , 10)
            };
        }
        internal void InfoWeapons()
        {
            for (int i = 0; i < weapons.Length; i++) 
            {
                Console.WriteLine(weapons[i]);
            }
        }
        internal void InfoArmors()
        {
            for(int i = 0;i < armors.Length; i++)
            {
                Console.WriteLine(armors[i]);
            }
        }

        internal void InfoAllSkills()
        {
            Console.WriteLine("\nНавыки исцеления:\n");
            for (int i = 0; i < gameSkills.HealSkills.Length ; i++)
            {
                Console.WriteLine($"{gameSkills.HealSkills[i].Name}, Затраты маны: {gameSkills.HealSkills[i].Mana}");
            }
            Console.WriteLine("\nНавыки наносящие большой урон:\n");
            for (int i = 0; i <gameSkills.epicSkills.Length; i++)
            {
                Console.WriteLine($"{gameSkills.epicSkills[i].Name}, Урон: {gameSkills.epicSkills[i].Damage}, Затраты маны: {gameSkills.epicSkills[i].Mana} ");
            }
            Console.WriteLine("\nОбычные навыки:\n");
            for(int i = 0; i < gameSkills.startSkills.Length ; i++)
            {
                Console.WriteLine($"{gameSkills.startSkills[i].Name}, Урон: {gameSkills.startSkills[i].Damage}, Затраты маны: {gameSkills.startSkills[i].Mana}");
            }
        }

    }
}
