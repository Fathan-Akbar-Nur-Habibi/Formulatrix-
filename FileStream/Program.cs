﻿class Program { 
	static void Main ()
	{
		string path = @".\myFile.txt";
		using (FileStream fs = new(path,FileMode.OpenOrCreate)) 
		{
			Console.WriteLine("File open");
		}
	}
}