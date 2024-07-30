class Program 
{
	static int Counter = 0 ;
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
		Counter++;
		await Task.Delay(50);
		Console.WriteLine(Counter);
	}
}