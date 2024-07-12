using System.Reflection.PortableExecutable;

interface IEngine 
{ 
	void Start();// di dalam interface tidak dapat mendeklarasi variabel
	void Stop();
}

public class Electric: IEngine 
{
	public void Start() 
	{
		Console.WriteLine("start");
	}
	
	public void Stop()
	{
		Console.WriteLine("Stop");
	}
}

class Program 
{
	static void Main()
	{
		//komen di dalam method
	IEngine engine = new Electric();// sesuatu yang abstrak tidak dapat instance  
	// kalau mau membuat new untuk abstrak, dari childnya ke parentnya
	 engine.Start();
	}
}