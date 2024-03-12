using PR9_Remake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PR9
{
    class Dungeon
    {
        Random rand = new Random();

        internal Armor[] armors { get; set; }
        internal Weapon[] weapons { get; set; }
        internal string[] name;

        List<Enemy> MonstersLevelEasy = new List<Enemy>();
        List<Enemy> MonstersLevelNormal = new List<Enemy>();
        List<Enemy> MonstersLevelHard = new List<Enemy>();

        Shop shop = new Shop();

        public Dungeon()
        {
            AddMonstersArmorsAndWeapons();
        }

        private void AddMonstersArmorsAndWeapons()
        {
            name = new string[]
            {
                "Гоблин", "Кентавр", "Орк", "Гнолл", "Скелет", "Кобольдд", "Грифон",
                "Минотавр", "Гарпия", "Гаргулия", "Баргест", "Гоблин", "Базилиск", "Вурдалак", "Цыклоп",
                "Мантикора", "Гидра", "Высший Демон", "Виверна", "Сфинкс", "Лич-Владыка", "Балрог", "Банши"
            };

            armors = new Armor[]
            {
                new Armor("Кожанные сапоги", 1.25),
                new Armor("Лоскутная накидка", 1.25),
                new Armor("Чешуйчатый доспех", 1.25),
                new Armor("Каменный панцырь", 1.1),

                new Armor("Мифриловая броня", 1.25),
                new Armor("Кованные доспехи", 1.25),
                new Armor("Адамантитовый шлем", 1.25),
                new Armor("Броня из кости гиганта", 1.25),

                new Armor("Броня из драконий кожи", 1.25),
                new Armor("Изумрудная чешуйчатая броня", 1.25),
                new Armor("Сапоги из кристалического камня", 1.25),
                new Armor("Кираса из тёмного железа", 1.25),

            };

            weapons = new Weapon[]
            {
                new Weapon("Костяная Зубачистка", 10),
                new Weapon("Стальной Кинжал", 10),
                new Weapon("Деревянный Лук", 10),
                new Weapon("Каменный Молот", 10),

                new Weapon("Серебрянный клинок", 10),
                new Weapon("Эльфийский Лук", 10),
                new Weapon("Кинжал с ядовитым лезвием", 10),
                new Weapon("Огненный Меч", 10),

                new Weapon("Потоковый Клинок", 10),
                new Weapon("Экзатический Лук с длинным диапозоном", 10),
                new Weapon("Грозный Топор с остроконечным лезвием", 10),
                new Weapon("Пылающий Меч с кристальным остриём", 10),
            };
        }

        internal void CreateMonsters(string choice)
        {
            switch (choice)
            {
                case "1":
                    MonstersLevelEasy = new List<Enemy>();
                    {
                        new Enemy(name[rand.Next(0, 7)], rand.Next(40, 58), weapons[rand.Next(0, 4)], armors[rand.Next(0, 4)]);
                    }
                    break;
            }
        }


    }
}
