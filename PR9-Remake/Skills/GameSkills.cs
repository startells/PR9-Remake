using PR9_Remake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9.Skills
{
    class GameSkills
    {
        internal Skill[] startSkills { get; set; }
        internal Skill[] HealSkills { get; set; }
        internal Skill[] epicSkills { get; set; }

        public GameSkills()
        {
            startSkills = new Skill[]
            {
                new Skill("Огненный шар", 12.0, 10, 30),
                new Skill("Ледяной луч", 10.0, 8, 25),
                new Skill("Каменная глыба", 9.0 , 7, 25),
                new Skill("Электрический разряд", 7, 4, 20)
            };

            HealSkills = new Skill[]
            {
            new Skill("Слабое Исцеление", 30, 20 , 50),
            new Skill("Исцеление", 55 , 35, 100),
            new Skill("Сильное Исцеление", 80, 50, 150)
            };

            epicSkills = new Skill[]
            {
            new Skill("Взрывная волна", 22.0, 25, 125),
            new Skill("Ледяное копье", 25.0, 22, 175),
            new Skill("Смертоностный луч", 24.0, 19, 200)
            };
        }
        internal void InfoStartSkills()
        {
            for (int i = 0; i < startSkills.Length; i++)
            {
                Console.WriteLine($"{startSkills[i].Name} | Урон: {startSkills[i].Damage} | Потребление маны: {startSkills[i].Mana}");
            }
        }

        //internal AllySkill[] ally = new AllySkill[]             //Призыв союзника
        //{
        //    new AllySkill("Скелет", 6 , 40),
        //    new AllySkill("Каменный голем", 12 , 55),
        //    new AllySkill("Огненный элементаль", 18 , 70),
        //    new AllySkill("Призрачный рыцарь", 26 , 100),
        //    new AllySkill("Огненный дракон", 32 , 130)
        //};
    }
}
