using System.Diagnostics.Contracts;

abstract class Engine { 
	public string type;
	public abstract void Start();
	public abstract void Stop();
	public void GenerateRotation(){ 
		Console.WriteLine("Generate rotation..");
	}
	
}
class Diesel : Engine {
	public override void Start()
	{
		Console.WriteLine("diesel start");
	}
	public override Stop()
	{
	   Console.WriteLine("diesel stop");
	}
} 
class V8 : Engine { 
	public void Start()
	{
		Console.WriteLine("V8 start");
	}
	public void Stop()
	{
		Console.WriteLine("V8 Stop");
	}
}
class Electri: Engine
{
	public override void Start()
	{
		Console.WriteLine("electric start");
	}
	public override void Stop()
	{
		Console.WriteLine(" electric stop");
	}
}
class Car { 
	public Engine engine;
	public Car(Engine engine)
	{
		this.engine = engine;
	}
}
class Program
{
	static void Main ()
	{
		V8 v8 = new();
		Car car = new Car(v8);
	}
}