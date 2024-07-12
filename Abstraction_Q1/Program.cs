abstract class Engine { 
	public string type = "type";
	public abstract void Start();
	public void GenerateRotation()
	{
		Console.WriteLine("Generate rotation..");
	}
}
class Electric : Engine {
	public override void Start() //ambil alih
	{
		Console.WriteLine("electric start");
	}
}
class Program { 
	static void Main()
	{
		Electric electric = new();
		Console.WriteLine(electric.type);
	}
}