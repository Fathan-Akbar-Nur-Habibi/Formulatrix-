using System.Runtime.CompilerServices;

class Program { 
	static async Task Main()
	{
		Console.WriteLine("Program Started");
		Task task1 = null;
		Task task2 = null;
		task2 = Task.Run(async()=>
		{
			Console.WriteLine("task2 started");
			await task1;
			Console.WriteLine("task2 completed");
		});
		task1 = Task.Run(async()=> 
		{
			Console.WriteLine("task1 started");
			await task2;
			Console.WriteLine("task1 completed");
		});
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Program Finished");
	}

}