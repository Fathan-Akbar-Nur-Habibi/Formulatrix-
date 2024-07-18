class Program
{
	static void Main()
	{
		Dictionary<int, string> myDictionary = new();
		myDictionary.Add(1, "hello");
		myDictionary.Add(3, "foo");

		string result;
		bool status = myDictionary.TryGetValue(4, out result);
		Console.WriteLine(status);

	}
}