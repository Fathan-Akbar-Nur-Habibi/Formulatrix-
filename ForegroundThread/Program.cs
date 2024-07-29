class Program { 
	static void Main()
	{
		Console.WriteLine("Program Start");
		Thread t1= new Thread(Print);
		Thread t2 = new Thread(Fax); 
		Thread t3 = new Thread(Scan); 
		
		t1.Start();
		t2.Start();
		t3.Start();
		
		Console.WriteLine("Program Finished");
	}
	static void Print()
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(10000);
		Console.WriteLine("Print finished");
	}
	static void Fax ()
	{
		Console.WriteLine("Fax Start");
		Thread.Sleep(11000);
		Console.WriteLine("Fax Finished");
	}
	static void Scan ()
	{
		Console.WriteLine("Scan start");
		Thread.Sleep(5000);
		Console.WriteLine("Scan Finished");
	}
}