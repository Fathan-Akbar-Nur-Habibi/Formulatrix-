
using System.Net.Http.Headers;

class Program { 
	static void Main () 
	{
		Console.WriteLine("Program Start");
		Thread t1 = new Thread (Print);
		Thread t2 = new Thread (Fax);
		Thread t3 = new Thread (Scan);
		
		t1.Start();
		t2.Start(); 
		t3.Start(); 
		
		t1.Join();
		t2.Join();
		t3.Join();
		Console.WriteLine("Program Finish");
	}
	static void Print()
	{
		Console.WriteLine("print start");
		Thread.Sleep(10000);
		Console.WriteLine("Print finished");
	}
	static void Fax()
	{
		Console.WriteLine("Fax Start");
		Thread.Sleep(11000);
		Console.WriteLine("Tax Finish");
	}
	static void Scan ()
	{
		Console.WriteLine("scan start");
		Thread.Sleep(5000);
		Console.WriteLine("scan finish");
	}
}