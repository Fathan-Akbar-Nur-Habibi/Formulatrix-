using log4net;
using log4net.Config;
class Robot 
{ 	
	private ILog _log;
	public Robot (ILog log) 
	
	{
		_log = log;
	}
	public void MoveLeft() 
	{
		_log.Info("Move Left executed");
		Console.WriteLine("move...");
		Console.WriteLine("move left finish");
	}
	public void MoveRight()
	{
		_log.Info("move right executed");
		Console.WriteLine("move..");
		Console.WriteLine("move right finish");
	}
}

class Program 
{
	static void Main()
	{
		ILog logger = LogManager.GetLogger(typeof(Robot));
		XmlConfigurator.Configure(new FileInfo("log4net.config"));
		Robot robot = new Robot(logger);
		while(true)
		{
			robot.MoveLeft();
			robot.MoveRight();
		}
	}
}