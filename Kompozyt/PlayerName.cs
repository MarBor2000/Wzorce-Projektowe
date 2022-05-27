using System;

public class PlayerName : Game{
	
	private int col ;
	private int row ;
	private string name ;
	
	public PlayerName(int col, int row, string name)
	{
		this.col = col;
		this.row = row;
		this.name = name;
	}

	public void showBar()
	{
		Console.WriteLine($"Player name {name} placed in col {col} and in row {row}");
	}
}
