using System.Collections.Generic;

public class Composite {
	private List<Game> Components ;

	public Composite()
	{
		Components = new List<Game>();
	}
	public void Add(Game component){
		Components.Add(component);
	}
	public void Remove(Game component)
	{
		Components.Remove(component);
	}

	public void showBar()
	{
		foreach (var i in Components)
		{
			i.showBar();
		}
	}
}
