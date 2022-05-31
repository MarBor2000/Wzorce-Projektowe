public class BearController {
	public string GetBeer(BeerFactory beerType)
	{
		return beerType.GetBeer();
	}
}
