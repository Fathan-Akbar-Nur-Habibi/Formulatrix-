public delegate int MyDelegate(int a, int b);
class Calculator 
{
	public int Add(int a, int b)
	{
		return a+b;
	}
	public int Sub(int a, int b)
	{
		return a-b;
	}
	public int Multiply( int a, int b)
	{
		return a*b;
	}
}
class Program 
{
	static void Main()
	{
		Calculator cal = new ();
		MyDelegate myDelegate = cal.Add;
		del += cal.Sub;
		del += cal.Multiply;
		
		int result = del.Invoke(5,3);
		Console.WriteLine(result);
	}
}