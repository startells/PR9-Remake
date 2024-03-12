using PR9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9_Remake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Dungeon & Heroes!");

            Hub hub = new Hub();
            hub.Start();
            hub.ThePlayerChoice();
        }
    }
}
