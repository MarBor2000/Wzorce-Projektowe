using System.Collections.Generic;

public class Uzytkownik {
	public List<Fanpage> Observers { get; set; }


	public Uzytkownik()
	{
		Observers = new List<Fanpage>();
	}

	public void AddObserver(Fanpage observers){
		Observers.Add(observers);
	}
	public void RemoveObserver(Fanpage observers)
	{
		Observers.Remove(observers);
	}
	public void powiadom(){
		foreach (var i in Observers)
		{
			i.powiadom();
		}
	}
}
