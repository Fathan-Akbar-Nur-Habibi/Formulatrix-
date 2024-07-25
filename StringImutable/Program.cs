class Program 
{
	static void Main() { 
		string a = "a";
		int iteration = 1_000;
		
		for (int i=0;i< iteration; i++) 
		{
			a+= "b" ;
			a+= "i";
			a.Replace("a","c");
			Thread.Sleep(2);
		}
	}
}