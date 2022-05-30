public class WithSurowka : KebabDecorator{
	public string Make()
	{
		KebabDecorator kebabik = new KebabDecorator();
		return $"{kebabik.Make()} z surowka";
	}
}
