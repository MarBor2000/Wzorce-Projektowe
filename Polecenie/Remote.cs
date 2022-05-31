public class Remote {
	public Command com ;
	public Remote(){
		
	}
	public void setCom(Command command)
	{
		com = command;
	}
	public void execute(){
		com.exe();
	}
}
