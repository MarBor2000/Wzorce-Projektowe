using System;


namespace MetodaSzablanowa
{
    public class Program
    {
        public static void Main()
        {
            int[] array = {21, 312, 42, 1, 156, 2, 485, 12};
            InsertionSort sortuj = new InsertionSortAsc();
            
            Console.WriteLine("Tablica przed sortowaniem");
            
            foreach (var i in array)
            {
                Console.WriteLine($"{i}");
            }
            
            sortuj.Sort(ref array);
            Console.WriteLine("Tablica posortowana rosnaco");
            foreach (var i in array)
            {
                Console.WriteLine($"{i}");
            }
            
            sortuj = new InsertionSortDec();
            
            sortuj.Sort(ref array);
            Console.WriteLine("Tablica posortowana malejaco");
            foreach (var i in array)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}