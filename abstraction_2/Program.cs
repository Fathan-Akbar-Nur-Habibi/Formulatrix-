class Parent { 
	public virtual void Kuliah()
	{
		Console.WriteLine("UGM");
	}
}
class Child : Parent 
{
	public override void Kuliah()
	{
		Console.WriteLine("Undip");
	}
	public void CheckparentKuliah()
	{
		base.Kuliah();
	}
}
class Program { 
	static void Main()
	{
		Child child = new();
		child.Kuliah();
		child.CheckparentKuliah();
	}
}