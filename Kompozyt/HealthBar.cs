using System;

public class HealthBar : Game{
	
	private int col { get; set; } 
	private int row { get; set; }
	
	public HealthBar(int col, int row)
	{
		this.col = col;
		this.row = row;
	}


	public void showBar()
	{
		Console.WriteLine($"Healt bar placed in row {row} and in column {col}");
	}
}
