using System;

public class BasicCar : CarPrototype{
	
	
	private string name ;
	private bool czyDwaRazyDrozszeJakSieZatankuje ;
	private int maxPredkosc ;
	
	public BasicCar(string name, bool czyDwaRazyDrozszeJakSieZatankuje, int maxPredkosc)
	{
		this.name = name;
		this.czyDwaRazyDrozszeJakSieZatankuje = czyDwaRazyDrozszeJakSieZatankuje;
		this.maxPredkosc = maxPredkosc;
	}

	public void setName(string Name)
	{
		name = Name;
	}

	public string getName()
	{
		return name;
	}
	
	public void setmaxP(int maxP)
	{
		maxPredkosc = maxP;
	}

	public int getmaxP()
	{
		return maxPredkosc;
	}

	public void setCzyDwa(bool czyDwa)
	{
		czyDwaRazyDrozszeJakSieZatankuje = czyDwa;
	}

	public bool getCzyDwa()
	{
		return czyDwaRazyDrozszeJakSieZatankuje;
	}
	
	public CarPrototype Clone()
	{
		BasicCar clone = (BasicCar) this.MemberwiseClone();
		Console.WriteLine($"Tico clone name is = {clone.name}, maxPredkosc = {clone.maxPredkosc},is it twice as expensive if you fill up = {clone.czyDwaRazyDrozszeJakSieZatankuje}");
		return clone;
	}
}
