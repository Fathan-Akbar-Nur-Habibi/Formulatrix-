// after inheritance

class Systemdesign 
{
	public string initalDesign ;
	public string processDesign;
	public string plantManagement; 
	//public void Review_design () {}
	public Systemdesign (string initalDesign, string processDesign, string plantManagement)
	{ 
		this.initalDesign = initalDesign;
		this.processDesign = processDesign;
		this.plantManagement = plantManagement;
	}
}
class Controlsystem : Systemdesign

{
	public string feedbackSystem;
	public string forwardSystem;
	public string disturbanceSystem;
	//public void multivariable_system(){}
	 
	public Controlsystem(string initalDesign,
						string processDesign,
						string plantManagement,
						string feedbackSystem,
						string forwardSystem,
						string disturbanceSystem) : base (initalDesign,processDesign,plantManagement)
	
	{
		this.feedbackSystem = feedbackSystem;
		this.forwardSystem = forwardSystem;
		this.disturbanceSystem = disturbanceSystem;
	}
}

class Instrumentdesign : Systemdesign
{ 
	public string electricalSystem; //menggunakan camelCase
	public string measurumentMethod; //menggunakan camelCase
	//public void Field_design(){}
	public Instrumentdesign (string initalDesign,
							 string processDesign,
							 string plantManagement,
							 string electricalSystem,string measurumentMethod): base (initalDesign,processDesign,plantManagement)
	{ 
		this.electricalSystem = electricalSystem;
		this.measurumentMethod = measurumentMethod;
	}
}


class Digitaldesignsystem : Systemdesign

{
	public string signalProcessing;
	public string plc;
	// public void Embadded_process (){}
	public Digitaldesignsystem (string initalDesign,
								string processDesign,
								string plantManagement,string signalProcessing, 
								string plc) : base (initalDesign,processDesign,plantManagement)
	
	{
		this.signalProcessing = signalProcessing;
		this.plc = plc;
	}
}

class Program
{     
	static void Main ()
	{
		Controlsystem controlsystem = new Controlsystem("thermal boiler design"," transfer heat & fluid","EPC Management","4 kali feedback","1 kali forward fluid","noise and vibration machine");
	    
	}
	
	
	  
	
}