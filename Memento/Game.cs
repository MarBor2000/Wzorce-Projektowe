using System;
public class Game : memento{
	public Game(int lvl, int expNeeded)
	{
		this.lvl = lvl;
		this.expNeeded = expNeeded;
	}
	
	public void createMemento()
	{
		save = (Game)this.MemberwiseClone();
	}
	
	public void resetoreMemento()
	{
		if (save != null)
		{
			Console.WriteLine("Restoring memento..");
			this.lvl = save.lvl;
			this.expNeeded = save.expNeeded;
			Console.WriteLine("Memento restored!");
		}
		else
		{
			Console.WriteLine("No memento");
		}
	}

	public int lvl { get; set; }
	public int expNeeded { get; set; } 
	private Game save { get; set; }

}
