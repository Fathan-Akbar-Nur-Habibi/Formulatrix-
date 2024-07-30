class Program 
{
	static int Counter = 0 ;
	static object mylock = new (); // must be created static object
	static async Task Main ()
	{
		Console.WriteLine("Method Start ...");
		Task task1 = Task.Run(Incrementer);
		Task task2 = Task.Run(Incrementer); 
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Method Complete");
	}
	static async Task Incrementer()
	{
		for (int i = 0; i<10; i++);
		lock(mylock)
		{
			Counter++;
			Console.WriteLine(Counter);
		}
		
		await Task.Delay(50);
		
	}
}