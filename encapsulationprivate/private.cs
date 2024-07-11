namespace encapsulationprivate;

public class Car { 
	private int price; 
	public string brand; 
	public void Start() { 
		Console.WriteLine("start");
	}	
}
public void CheckPrice() { 
	 Console.WriteLine(price);
}
public void AddPrice(int add)
{
	price += add;
}
class Program 
{
	static void Main()
	{
		Car car = new Car (); 
		car.AddPrice(2000);
		car.CheckPrice();
	}
}
