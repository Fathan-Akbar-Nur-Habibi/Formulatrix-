interface ISystemDesign 
{
	void Electrical();
	void Mechanical();
	void ReviewDesign();
}
public class Automation : ISystemDesign
{
	public void Electrical()
	{
		Console.WriteLine ("Electrical System"); 
	}
} 
public class Building : ISystemDesign 
{
   public void Mechanical()
   {
   	Console.WriteLine("Mechanical Structure");
   }	
}
public class Result : ISystemDesign 
{
	public void 
}