public class Or : Expresion{
	
	public Expresion exp1 { get; set; }
	public Expresion exp2 { get; set; }
	
	public Or(Expresion exp1, Expresion exp2)
	{
		this.exp1 = exp1;
		this.exp2 = exp2;
	}

	public bool interpret(int con)
	{
		return exp1.interpret(con) || exp2.interpret(con);
	}
}
