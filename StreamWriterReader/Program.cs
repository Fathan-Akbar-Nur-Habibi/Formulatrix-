using System.Text;
class Program { 
	static void Main ()
	{
		string path = @".\myFile.txt";
		using (StreamWriter sw = new(path))
		{
			sw.WriteLine("okee");
		}
		using (StreamReader sr = new(path))
		{
			string result = sr.ReadLine();
			if (result is not null)
			{
				Console.WriteLine(result);
			}
		}
	}
}