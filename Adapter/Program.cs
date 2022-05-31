using System;

namespace Adapter
{
    internal class Program
    {
        public static void Main()
        {
            Passat passatinio = new Passat();
            KidCar hotweelsik = new HotWeels();

            KidCar adapter = new CarAdapter(passatinio);
            
            Console.WriteLine("---Passat---");
            passatinio.drive();
            passatinio.radioOn();
            Console.WriteLine("---HotWeels");
            hotweelsik.fun();
            Console.WriteLine("---Adapter");
            adapter.fun();
        }
    }
}