public class WithSos : KebabDecorator{
	public string Make()
	{
		WithSurowka sur = new WithSurowka();
		return $"{sur.Make()} z sosem ostrym";
	}
}
