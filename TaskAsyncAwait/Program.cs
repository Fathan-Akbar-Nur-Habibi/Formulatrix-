class Program { 
	static async Task Main() 
	{
		CancellationTokenSource ultrasonSensor = new CancellationTokenSource();
		CancellationTokenSource piezoelectricSensor = new CancellationTokenSource();
		Task t1 = Task.Run(()=> DetectionUltrasonSensing (ultrasonSensor.Token));
		Task t2 = Task.Run(() => DetectionPiezoSensing(piezoelectricSensor.Token));
		Task t3 = Task.Run(async () => 
		{
			await Task.Delay(15000);
			ultrasonSensor.Cancel();
			piezoelectricSensor.Cancel();
		});
		await Task.WhenAll(t1,t2,t3);
		Console.ReadLine();
	}
	
	static async Task DetectionUltrasonSensing(CancellationToken uls) { 
		while (!uls.IsCancellationRequested){ 
			Console.WriteLine("Monitoring Corrosion In Pipeline");
			await Task.Delay(10000);
		}
		Console.WriteLine("Corrosion Ddetected In Pipeline");
	}
	
	static async Task DetectionPiezoSensing(CancellationToken pz) { 
		
		while (!pz.IsCancellationRequested)
		{
			Console.WriteLine(" Monitor Dynamic Pressure");
			await Task.Delay(10000);
			for (int pressurePipeline = 10; pressurePipeline > 5; pressurePipeline-- )
			{
				Console.Write(pressurePipeline);
			}
		}
		Console.WriteLine(" Gas Low Pressure in Pipeline");
	}
	
}