class Engine { 
	private void Run()
	{
		Console.WriteLine("engine run");
	}
}
class ElectricalEngine : Engine { 
	public void off()
	{
		Engine engine = new Engine();
		Console.WriteLine(" engine off");
	}
}
class Program { 
	static void Main ()
	{
		Engine engine = new Engine ();
		engine.Run();// ERROR KARENA PRIVATE
		engine.Off(); // ERROR KARENA PRIVATE
		 
		ElectricalEngine electricalEngine = new ElectricalEngine ();
		electricalEngine.Run();// ERROR KARENA PRIVATE
		electricalEngine.off();
	}
}