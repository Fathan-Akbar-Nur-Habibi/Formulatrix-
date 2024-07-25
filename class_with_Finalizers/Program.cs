using System.Diagnostics;
class MyClassA()
{
	~MyClassA(){}
}
class MyClassB()
{
	~MyClassB(){}
} 
class MyClassC ()
{
	~MyClassC(){}
}
class Pprogram 
{
	static void Main()
	{
		int iteration = 1_000_000;
		Stopwatch stopwatch = new();
		stopwatch.Start();
		for(int i=0; i< iteration;i++)
		{
			MyClassA a = new();
			MyClassB b = new();
			MyClassC c = new();
		} 
		stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
	}
}