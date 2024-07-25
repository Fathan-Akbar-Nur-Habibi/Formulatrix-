class Program { 
	static void Main ()
	{
		float [] myfloats = new float[100*1024];// 400 KB
		Console.WriteLine(GC. GetGeneration(myfloats));
		
	}
}