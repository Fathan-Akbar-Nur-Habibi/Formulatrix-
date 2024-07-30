class Program { 
	static void Main() 
	{
		CancellationTokenSource ultrasonSensor = new CancellationTokenSource();
		CancellationTokenSource piezoelectricSensor = new CancellationTokenSource();
		Task t1 = Task.Run(()=> DetectionUltrasonSensing (ultrasonSensor.Token));
		Task t2 = Task.Run(() => DetectionPiezoSensing(piezoelectricSensor.Token));
		Task t3 = Task.Run(() => 
		{
			Thread.Sleep(15000);
			ultrasonSensor.Cancel();
			piezoelectricSensor.Cancel();
		});
		Task.WaitAll(t1,t2,t3);
		Console.ReadLine();
	}
	
	static void DetectionUltrasonSensing(CancellationToken uls) { 
		while (!uls.IsCancellationRequested){ 
			Console.WriteLine("Monitoring Corrosion In Pipeline");
			Thread.Sleep(10000);
		}
		Console.WriteLine("Corrosion Ddetected In Pipeline");
	}
	
	static void DetectionPiezoSensing(CancellationToken pz) { 
		
		while (!pz.IsCancellationRequested)
		{
			Console.WriteLine(" Monitor Dynamic Pressure");
			Thread.Sleep(10000);
			for (int pressurePipeline = 10; pressurePipeline > 5; pressurePipeline-- )
			{
				Console.Write(pressurePipeline);
			}
		}
		Console.WriteLine(" Gas Low Pressure in Pipeline");
	}
	
}