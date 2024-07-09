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
		int result_1 = calculator.add(inputUser_1,inputUser_2);
		
		Console.WriteLine(result_1);
		
		string value_3 = Console.ReadLine();
		int inputUser_3 = int.Parse(value_3);	
		Console.WriteLine("Masukan angka kedua");
		string value_4 = Console.ReadLine();
		int inputUser_4 = int.Parse(value_4);
		
		int result_2 = calculator.Multiply(inputUser_3,inputUser_4);
		
		string value_5 = Console.ReadLine();
		int inputUser_5 = int.Parse(value_5);	
		Console.WriteLine("Masukan angka kedua");
		string value_6 = Console.ReadLine();
		int inputUser_6 = int.Parse(value_6);
		
		int result_3 = calculator.Subtraction(inputUser_5,inputUser_6);
	 	
		
	}
	
}