using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR9.Skills;
using PR9_Remake;

namespace PR9
{
    class Hub
    {
        GameSkills gameSkills = new GameSkills();
        Dungeon dungeon = new Dungeon();
        Shop shop = new Shop();

        internal Hero character;
            string name;
        

        internal void Start()
        {
            Console.Write("Введите имя персонажа: ");
            name = Console.ReadLine();

            Console.WriteLine("\nВыберите оружие: ");
                shop.InfoWeapons();
                    int choiceWeapon = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВыберите начальное умение: ");
                gameSkills.InfoStartSkills();
                    int choiceSkill = int.Parse(Console.ReadLine());

            character = new Hero(name, shop.weapons[choiceWeapon - 1], shop.armors[0], new List<Skill> { gameSkills.startSkills[choiceSkill - 1] });
        }

        internal void ThePlayerChoice()
        {
            //InfoHero(character);
            Store();
        }

        internal void InfoHero(Hero hero)
        {
            Console.WriteLine("Ваш герой: ");
            Console.WriteLine($"Имя: {hero.Name} | Здоровье: {hero.Health} | Мана: {hero.Mana} | \n{hero.armor} | {hero.weapon} | ");
        }

        internal void Store()
        {
            Console.WriteLine("Добро пожаловать в магазин!");
                Console.WriteLine("1. Навыки \n2. Оружие \n3. Броня");
                    string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    shop.InfoAllSkills();
                    break;
                default:
                    Console.WriteLine("Неверный выбор..."); 
                    break;
            }
        }

        internal void GoDungeon()
        {
            string choice = Console.ReadLine();
            dungeon.CreateMonsters(choice);
        }
    }
}
