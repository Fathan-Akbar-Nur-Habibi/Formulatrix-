using System.Xml.Serialization;
using System.IO;


public class Human { 
	public string Name { get;set; }
	public int Age { get; set; }
}
class Program 
{
	static void Main (){ 
		Human human = new Human();
		human.Name = "jiki";
		human.Age = 33;
		XmlSerializer serializer = new (typeof(Human));
		using (FileStream fs = new("./human.txt", FileMode.Create))
		{
			serializer.Serialize(fs, human);
		}
	}
}
