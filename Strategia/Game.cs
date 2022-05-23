public class Game
{
	private Strategy strategy { get; set; } = new GoDrake();
	
	public void Exe(){
		strategy.Exe();
	}
	
	public void Set(Strategy strategyy)
	{
		strategy = strategyy;
	}
}
