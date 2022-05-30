public class Terminal : Expresion{
	public int data ;

	public Terminal(int data)
	{
		this.data = data;
	}

	public bool interpret(int con)
	{
		if (con == data)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
