using System.Xml.Serialization;
using System.IO;


public class Human { 
	public string Name { get;set; }
	public int Age { get; set; }
	public Human(string name, int age)
	{
		Name = name; 
		Age = age; 
	}
	public Human(){}
}
class Program 
{
	static void Main (){ 
		Human human = new Human();
		Human human2 = new Human();
		Human human3 = new Human();
		
		List<Human> futurePresident = new();
		futurePresident.Add(human);
		futurePresident.Add(human2);
		futurePresident.Add(human3);
	
		XmlSerializer serializer = new (typeof(List<Human>));
		using (FileStream fs = new("./human.txt", FileMode.Create))
		{
			serializer.Serialize(fs, futurePresident);
		}
	}
}
