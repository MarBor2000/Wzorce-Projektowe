namespace Kompozyt
{
    internal class Program
    {
        public static void Main()
        {

            Composite comp = new Composite();
            HealthBar Player = new HealthBar(0, 2);
            PlayerName player = new PlayerName(0, 1, "Boro");
            HealthBar Monster = new HealthBar(5, 4);
            PlayerName monster = new PlayerName(5, 3, "Mummia");
            HealthBar Monster2 = new HealthBar(9, 4);
            PlayerName monster2 = new PlayerName(9, 3, "Sfinks");
            
            comp.Add(Player);
            comp.Add(player);
            comp.Add(Monster);
            comp.Add(monster);
            comp.Add(Monster2);
            comp.Add(monster2);
            
            comp.showBar();

        }
    }
}