// private Naming Convention 

public class Aerospace 
{
	private string _type;
	public Aerospace (string type)
	{
		_type = type;
	}
	
	
}
class Program { 
	static void Main() { 
		Aerospace aerospace = new Aerospace ("Hj-780");
		Console.WriteLine(aerospace);
	}
}