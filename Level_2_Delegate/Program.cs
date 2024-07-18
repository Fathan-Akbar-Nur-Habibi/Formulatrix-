  public delegate void MyDelegate();

class Publisher 
{
	private MyDelegate _del;
	
	public void AddSubcriber(MyDelegate method)
	{
		_del += method;
	}
	public void RemoveSubscriber(MyDelegate method)
	{
		_del -= method;
	} 
} 

class Subscriber 
{
	public void Subscribe(){ }
}

class Program 
{
	static void Main()
	{
		Publisher pub = new();
		Subscriber sub = new Subscriber();		
		pub.AddSubcriber(sub.Subscribe);
		pub.RemoveSubscriber(sub.Subscribe);
		
	}
}