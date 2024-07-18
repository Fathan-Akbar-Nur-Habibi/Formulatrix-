﻿using System.Diagnostics.Contracts;
public delegate void MyDelegate();
class Publisher 
{
	public event MyDelegate del;
	public void Reset () 
	{
		del = null; 
	}
}
class Subscriber 
{
	public void GetNotification(){}
}
class Program 
{
	static void Main()
	{
		Publisher pub = new();
		Subscriber sub = new Subscriber();
		
		pub.del += sub.GetNotification; 
		pub.del += sub.GetNotification;
	}
}