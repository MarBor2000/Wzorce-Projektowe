public class BearFactory : BearController{
	
	public Barman method(string type){
		if (type == "Harnas")
		{
			return new Harnas();
		}
		else if (type == "Mentzen")
		{
			return new Mentzen();
		}
		else
		{
			return new Perla();
		}
	}
	
}
