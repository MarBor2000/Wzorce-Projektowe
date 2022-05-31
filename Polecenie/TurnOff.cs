public class TurnOff : Command{
	private Computer computer ;

	public TurnOff(Computer computer)
	{
		this.computer = computer;
	}

	public void exe()
	{
		computer.off();
	}
}
