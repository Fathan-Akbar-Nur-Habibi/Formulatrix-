using System.Diagnostics.Contracts;

class Program 
{
	static void Main ()
	{
		Console.WriteLine("Program Start"); 
		Task t1 = new Task(() => Print("this is message")); 
		t1.Start();
		Task t2 = Task.Run(() => Print("this is message")); 
		Console.WriteLine("Program Finished");
	}
	static void Print(string message){
	Console.WriteLine("Print Start");
	Thread.Sleep(5000);
	Console.WriteLine("Print Finished"+ message);
	}
}