class Calculator { 
		public int add(int a, int b) => (a+b);
}

class Program 
{
	static void Main ()
	{
		Console.WriteLine("Program Start");
		Calculator calculator = new (); 
		int result = calculator.add(3,5);
		Console.WriteLine(result);
	}
}
