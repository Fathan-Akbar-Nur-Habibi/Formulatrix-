class Cat
{
	public bool manja;
	public string colour;
	public string gender;
	
	public void Eat(string jenisMakanan)
	{
		Console.WriteLine("Cat eat " + jenisMakanan);
	}
	public void Poop()
	{
		Console.WriteLine("Cat poop");
	}
}
class Program
{
	static void Main() 
	{
		Cat cat = new Cat();
		string inputUser  = Console.ReadLine();
		int makanan = int.Parse(inputUser); // parsing  = metode convert
		cat.Eat(makanan);
		cat.Poop();
	}
}