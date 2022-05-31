public class PlayLol : Command{
	private Computer computer ;

	public PlayLol(Computer computer)
	{
		this.computer = computer;
	}

	public void exe()
	{
		computer.play();
	}
}
