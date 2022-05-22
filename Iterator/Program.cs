using System;
using System.Collections.Generic;

namespace WzorzecIterator
{
    internal class Program
    {
        public static void Main()
        {
            Cw cwiczenie1 = new Cw("Lawka", 5, 8);
            Cw cwiczenie2 = new Cw("Wyciskanie wasko", 3, 6);
            Cw cwiczenie3 = new Cw("Rozpietki", 4, 8);
            Cw cwiczenie4 = new Cw("Przysiady", 3, 3);
            Cw cwiczenie5 = new Cw("Wyciskanie francuskie", 4, 8);
            Cw cwiczenie6 = new Cw("Brzuszki 90 stopni", 5, 20);

            List<Cw> planik = new List<Cw>();
            
            planik.Add(cwiczenie1);
            planik.Add(cwiczenie2);
            planik.Add(cwiczenie3);
            planik.Add(cwiczenie4);
            planik.Add(cwiczenie5);
            planik.Add(cwiczenie6);

            PlanTreningowy Iterator = new PlanTreningowy(planik);
            while (Iterator.NextExerciseExist())
            {
                Console.WriteLine(Iterator.Next().Name);
                Console.WriteLine($"Liczba serii = {Iterator.actual().NumberOfSeries}");
                Console.WriteLine($"Liczba powtorzen = {Iterator.actual().NumberOfRepetitions}");
            }

        }
    }
}