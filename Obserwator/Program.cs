using System;

namespace Obs
{
    internal class Program
    {
        public static void Main()
        {
            Administrator Marek = new Administrator();
            Moderator Wojtek = new Moderator();
            Uzytkownik uzytk = new Uzytkownik();
            Obserwujacy Rafal = new Obserwujacy();
            
            
            uzytk.AddObserver(Marek);
            uzytk.AddObserver(Wojtek);
            uzytk.AddObserver(Rafal);
            uzytk.powiadom();
            
            uzytk.RemoveObserver(Wojtek);
            Console.WriteLine("---------------");
            uzytk.powiadom();
            
        }
    }
}