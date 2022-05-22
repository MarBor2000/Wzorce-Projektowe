using System.Collections.Generic;

public class PlanTreningowy : Iterator
{
	private int nr { get; set; } = -1;
	private List<Cw> Plan { get; }
	public PlanTreningowy(List<Cw> plan)
	{
		Plan = plan;
	}

	public Cw Next()
	{
		nr += 1;
		return Plan[nr];
	}

	public Cw actual()
	{
		return Plan[nr];
	}

	public bool NextExerciseExist()
	{
		return nr != Plan.Count-1;
	}
}
