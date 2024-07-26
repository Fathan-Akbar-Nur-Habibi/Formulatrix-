using System;
using System.Reflection.PortableExecutable;
using System.Threading;

class Program 
{
	static void Main()
	{
		Thread thread1 = new Thread(Ex1); // creat thread
		Thread thread2 = new Thread(Ex2);
		thread1.Start(); // start thread
		thread2.Start(); 
	}
	static void Ex1()
	{
	Console.WriteLine("Thread1 Started");
	for (int i = 0; i< 10; i++)
	{
		Console.WriteLine("Thread1 execute");
		Thread.Sleep(5000);// for pause thread
	}
	}
	static void Ex2()
	{
	Console.WriteLine("Thread2 Started");
	for (int i = 0; i< 10; i++)
	{
		Console.WriteLine("Thread2 execute");
		Thread.Sleep(5000);// for pause thread
	}
	}
}
