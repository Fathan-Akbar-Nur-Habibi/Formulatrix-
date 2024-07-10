using System.ComponentModel;
using System.Drawing;
using Microsoft.VisualBasic;

class Aerospace 
{ 
	public Type type;
	public  Mechanics mechanics;
	public Size size;
	public Aerospace (Type type,
					  Mechanics mechanics, 
					Size size)
				{ 
				 this.mechanics = mechanics;
				 this.size = size;
				 this. type = type;
				 
			
				}
	
}

class Mechanics 
  { 
	public string turbine; 
	public string service; 
	public void start()
		 
		 {
		 	Console.WriteLine ("Mechanical System proprties : {turbine} and Urgent Service : {service}");
		 }

  }
  
class Size
{
	public string besar; 
	public string sedang; 
	public string kecil;

	 
}

class Type 
{ 
	public string boeing;
	public string hercules; 
	

}

class Program 
{ 
	static void Main()
	{ 
		Mechanics mechanics = new Mechanics();
		mechanics.turbine = "HZ-1206"; 
		mechanics.service="System turbine error";
		
		Type type_aero = new Type();
		type_aero.boeing = "Boeing JH-78";
		
		Size size_aero = new Size();
		size_aero.besar = " Besar"; 
		
		// belum terpenuhi
		Aerospace aerospace = new Aerospace (type_aero, mechanics,size_aero) ; // yang di dalam kurung yaitu sesuai objek nya
		aerospace.mechanics = mechanics;
		Console.WriteLine(aerospace.mechanics.turbine);
		
	}  
	
}