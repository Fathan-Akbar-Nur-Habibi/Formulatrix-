class Calculator { 
	public object Multiply(object a, object b)
	{
		return (int) a * (int)b;
	}
}

class Program 
{
	static void Main()
	{
		int a = 5;
		int b = 10;
		Calculator calculator = new Calculator();
		calculator.Multiply(5,10);
		Console.WriteLine(calculator.Multiply);
	}
}