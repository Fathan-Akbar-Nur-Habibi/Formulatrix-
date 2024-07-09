using System.ComponentModel;
using CalculatorLib;

class Program 
{ 
	static void Main ()
	
	{
		Calculator calculator = new Calculator();
		Console.WriteLine("Masukan angka pertama");
		string value_1 = Console.ReadLine();
		int inputUser_1 = int.Parse(value_1);	
		Console.WriteLine("Masukan angka kedua");
		string value_2 = Console.ReadLine();
		int inputUser_2 = int.Parse(value_2);
		
		
		
		int result_1= calculator.add(inputUser_1,inputUser_2);
		Console.WriteLine(result_1);
		
		int result_2 = calculator.Multiply(inputUser_1,inputUser_2);
		Console.WriteLine(result_2);
		 
		int result_3= calculator.Subtraction(inputUser_1,inputUser_2);
		 Console.WriteLine(result_3);
		
		
	}
	
}