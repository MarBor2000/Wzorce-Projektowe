using System;

namespace Prototyp
{
    public class Program
    {
        public static void Main()
        {
            GoodCar passat = new GoodCar("Passat",200);
            BasicCar car = new BasicCar("Daewoo Tico", true, 100);
            
            Console.WriteLine($"Name {passat.getName()}, max km/h = {passat.getmaxP()}");
            Console.WriteLine($"Name {car.getName()}, max km/h = {car.getmaxP()}, full tanked = 2* more expensive ? {car.getCzyDwa()}");

            GoodCar passatC = (GoodCar) passat.Clone();
            passatC.setName("Mustang");
            passat.setmaxP(300);


            BasicCar carC = (BasicCar) car.Clone();
            carC.setName("Limuzyna");
            carC.setCzyDwa(false);
            
            Console.WriteLine("---Original---");
            Console.WriteLine($"Name {passat.getName()}, max km/h = {passat.getmaxP()}");
            Console.WriteLine("---Clone---");
            Console.WriteLine($"Name {passatC.getName()}, max km/h = {passatC.getmaxP()}");
            
            
            Console.WriteLine("---Original---");
            Console.WriteLine($"Name {car.getName()}, max km/h = {car.getmaxP()}, full tanked = 2* more expensive ? {car.getCzyDwa()}");
            Console.WriteLine("---Copy---");
            Console.WriteLine($"Name {carC.getName()}, max km/h = {carC.getmaxP()}, full tanked = 2* more expensive ? {carC.getCzyDwa()}");

        }
    }
}