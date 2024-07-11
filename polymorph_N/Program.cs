class Transportation 
{
	public string type;
	public virtual void price () //polymorph
	{
		Console.WriteLine( "Rp.");
	}
}
class Bus : Transportation 
{
	public override void price(){ //polymorph
		Console.WriteLine(" h");
	}
}