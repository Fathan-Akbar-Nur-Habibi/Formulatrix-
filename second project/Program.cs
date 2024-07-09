class Cow
//Pascalcase = function class
	// camelCase = attribute/variable
{
   public bool males;
   public string warna;
   public bool isMale; 
// function 
  static void Main()
	{ 
		Cow kecil = new Cow();
		kecil.males = false;
		kecil.warna = "Black";
		kecil.isMale = true;
		
		Console.WriteLine(kecil.males);
		Console.WriteLine(kecil.warna);
		Console.WriteLine(kecil.isMale);
	}	
}

