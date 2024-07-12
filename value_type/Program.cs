using System.Xml.XPath;

class Value 
{
	public int A ;
	public int B; 
}
class Program 
{
	static void Main()
	{
	 Value value = new();
	 value.A = 30;
	 //value.B = value.A;
	 Console.WriteLine(value.A);
	}
}