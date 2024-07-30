class Program { 
	static async Task Main ()
	{
		while (true)
		{
			Console.WriteLine("test");
			await Task.Delay(10000);
		}
	}
}