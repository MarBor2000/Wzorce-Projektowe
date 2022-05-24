using System;

public class GoodCar : CarPrototype{
	
	private string name { get;set; } 
	private int maxPredkosc { get; set; }
	
	public GoodCar(string name, int maxPredkosc)
	{
		this.name = name;
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
	
	
	
	public CarPrototype Clone()
	{
		GoodCar clone = (GoodCar) this.MemberwiseClone();
		Console.WriteLine($"Passat clone name is = {clone.name}, maxPredkosc = {clone.maxPredkosc}");
		return clone;
	}
}
