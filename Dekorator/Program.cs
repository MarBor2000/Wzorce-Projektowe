using System;

namespace Dek
{
    internal class Program
    {
        public static void Main()
        {
            KebabDecorator kebabik = new KebabDecorator();
            
            Console.WriteLine($"{kebabik.Make()}");
            WithSurowka kebsik = new WithSurowka();
            Console.WriteLine($"{kebsik.Make()}");
            WithSos kebab = new WithSos();
            Console.WriteLine($"{kebab.Make()}");
        }
    }
}