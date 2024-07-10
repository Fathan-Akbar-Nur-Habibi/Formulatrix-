class Car 
{ 
	public string color;
	public int price;
	public string type;
	public Car (string color,
				int price,
				string type)
				{ 
				 this.color = color;
				 this.price = price;
				 this.type = type;	
				}
	
}
class Program
{ 
	static void Main() 
	{
		Car car = new Car("blue", 200,"suv");
		Console.WriteLine(car.color);
		Console.WriteLine(car.price);
		Console.WriteLine(car.type);
	}	
}