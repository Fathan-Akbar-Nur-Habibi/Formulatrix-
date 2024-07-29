
using System.Net.Http.Headers;

class Program { 
	static void Main () 
	{
		Console.WriteLine("Program Start");
		 Print ();
		 Fax();
	     Scan();
		
		Console.WriteLine("Program Finish");
	}
	static void Print()
	{
		Console.WriteLine("print start"); 
		Thread.Sleep(10000); //10 second
		Console.WriteLine("Print finished");
	}
	static void Fax()
	{
		Console.WriteLine("Fax Start");
		Thread.Sleep(11000); //11 second
		Console.WriteLine("Tax Finish");
	}
	static void Scan ()
	{
		Console.WriteLine("scan start");
		Thread.Sleep(5000); //5 second
		Console.WriteLine("scan finish");
	}
}