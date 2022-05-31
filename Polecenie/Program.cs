namespace Polecenie
{
    internal class Program
    {
        public static void Main()
        {
            Remote control = new Remote();
            Computer comp = new Computer();
            
            control.setCom(new TurnOn(comp));
            control.execute();
            control.setCom(new PlayLol(comp));
            control.execute();
            control.setCom(new TurnOff(comp));
            control.execute();
        }
    }
}