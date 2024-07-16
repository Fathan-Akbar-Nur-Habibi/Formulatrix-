class CapacityEngine 
{
	public int size = 3500 ;
	public static CapacityEngine operator+( CapacityEngine a, CapacityEngine b)// untuk operator overloading (menggunakan static)
	{
		int result = a. size + b.size;
		CapacityEngine capacityEngine = new CapacityEngine();
		capacityEngine.size = result;
		return capacityEngine;
	}
}
class Program { 
	static void Main ()
	{
		CapacityEngine capacityEngine_1 = new CapacityEngine();
		CapacityEngine capacityEngine_2 = new CapacityEngine();
		CapacityEngine result = capacityEngine_1 + capacityEngine_2;
		Console.WriteLine(result.size + " Hp");
	}
}