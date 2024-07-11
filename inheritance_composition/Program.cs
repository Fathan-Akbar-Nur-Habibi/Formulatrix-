using System.Runtime.CompilerServices;

class Control 
{
	public Multivariable multivariable;
	public Control (Multivariable multivariable)
	{
		this.multivariable = multivariable;
	}
}
class Multivariable 
{
	public string type_system;
	public string categorical_system;
}
class MethodMeasurument : Multivariable
{
	
}
class NoiseSystem : Multivariable {}
class Program { 
	static void Main ()
	{
		Multivariable multivariable = new Multivariable ();
		Control control = new Control(multivariable);
		MethodMeasurument methodMeasurument = new MethodMeasurument ();
		Control control2 = new Control(methodMeasurument);   
	}
}