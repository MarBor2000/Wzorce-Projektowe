using System;

namespace Metoda
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Harnas harnold = new Harnas();
            Perla perelka = new Perla();
            Mentzen mentzenik = new Mentzen();

            BearController Control = new BearController();
            Console.WriteLine(Control.GetBeer(harnold));
            Console.WriteLine(Control.GetBeer(perelka));
            Console.WriteLine(Control.GetBeer(mentzenik));
        }
    }
}