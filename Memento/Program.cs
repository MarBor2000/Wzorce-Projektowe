using System;

namespace Memento
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game gra = new Game(3, 2137);
            Console.WriteLine($"Poziom gracza {gra.lvl}, exp potrzebny do nastepnego lvlu {gra.expNeeded}");
            gra.resetoreMemento();
            gra.createMemento();
            gra.lvl = 4;
            gra.expNeeded = 420;
            Console.WriteLine($"Poziom gracza {gra.lvl}, exp potrzebny do nastepnego lvlu {gra.expNeeded}");
            gra.resetoreMemento();
            Console.WriteLine($"Poziom gracza {gra.lvl}, exp potrzebny do nastepnego lvlu {gra.expNeeded}");
        }
    }
}