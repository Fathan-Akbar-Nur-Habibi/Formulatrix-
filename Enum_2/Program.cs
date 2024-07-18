public enum MonthOfYear
{
	Jan = 1,
	Feb,
	Mar,
	Apr,
	May,
	Jun,
	Jul,
	Aug,
	Sep,
	Oct,
	Nov,
	Dec
}

class Program
{
	static void Main()
	{
		int result = (int)MonthOfYear.Mar;
		Console.WriteLine(result); // untuk mengetahui bulan keberapa

		MonthOfYear result2 = (MonthOfYear)3;
		Console.WriteLine(result2); // untuk mengetahui nama bulan 

		string x = MonthOfYear.Oct.ToString();
		Console.WriteLine(x); 
	}
}
