class MyClass : IDisposable
{
	private int[] myArray;
	private FileStream fs;
	private OfficeStream officeStream;
	private bool disposedValue;
	
	protected virtual void Dispose(bool disposing) 
	{
		if(!disposedValue)
		{
			if(disposing)
			{
				myArray = null;
			}
			fs.Dispose();
			officeStream = null;
			disposedValue= true;
		}
	}
	~MyClass ()
	{
		Dispose(disposing: false);
		GC.SuppressFinalize(this);
	}
}