using System;

namespace Strategia
{
    internal class Program
    {
        public static void Main()
        {
            var Game = new Game();
            Console.WriteLine("----10:23----");
            Game.Exe();
            var strat = new SplitTop();
            Console.WriteLine("----15:23----");
            Game.Set(strat);
            Game.Exe();
            Console.WriteLine("----21:37----");
            var strat2 = new GoNashor();
            Game.Set(strat2);
            Game.Exe();
            Console.WriteLine("----23:42----");
            var strat3 = new SplitBot();
            Game.Set(strat3);
            Game.Exe();
        }
    }
}