using System.Numerics;

class Calculator
{ 
	public T Add<T>(T a, T b)  where T: INumber<T> // generic dipindah untuk menjalankan program tanpa dibuat baru
	{
		return a + b;
	}
	public T Substract <T> (T a, T b) where T: INumber<T>
	{
		return a -b;
	}
	public T Multiply<T> (T a, T b) where T: INumber<T>
	
	{
		return a *b;
	}
	public T Division<T> (T a, T b) where T: INumber<T>
	{
		return a/b;
	}
}
class Program{ 
	static void Main(){ 
		Calculator calc = new();
		calc.Add<int> (3,4);
		calc.Substract<int> (6,1);
		calc.Multiply<int>(2,5);
		calc.Division<float> (4.0f, 2.0f);
		//Console.WriteLine (calc.Add);
	}
}