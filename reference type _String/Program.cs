using System.Runtime.CompilerServices;

class TypeCar 
{ 
	public string type1 = "suv";
	public string type2 = "sedan"; 
}
class Program { 
	static void Main()
	{
	   TypeCar  typeCar = new ();
	   typeCar.type1 = typeCar.type2;
	   Console.WriteLine(typeCar.type1);
	   Console.WriteLine(typeCar.type2);
	}
}