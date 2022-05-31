public class CarAdapter : KidCar
{
	public Car car;

	public CarAdapter(Car car)
	{
		this.car = car;
	}
	

	public void fun()
	{
		car.drive();
	}
	
}
