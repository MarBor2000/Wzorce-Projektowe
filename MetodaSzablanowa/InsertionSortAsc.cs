public class InsertionSortAsc : InsertionSort{
	public override bool Comparator(int x,int y)
	{
		return x > y;
	}
}
