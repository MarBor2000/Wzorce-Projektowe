public class TurnOn : Command{
	private Computer computer ;

	public TurnOn(Computer computer)
	{
		this.computer = computer;
	}

	public void exe()
	{
		computer.on();
	}
}
