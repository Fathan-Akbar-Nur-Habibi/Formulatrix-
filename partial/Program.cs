using System.Runtime.CompilerServices;

namespace MyProgram { 
	class Progrsm 
	{
		static void Main()
		{
		 Car car = new Car();
		 car.Run();// namespace of Car harus sama
		}
	}

partial class Car {}
}