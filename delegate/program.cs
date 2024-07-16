using Delegate;

class Program { 
	static void Main() { 
		Youtuber youtuber = new Youtuber();
		Notification notification = new();
		
		youtuber.subscribes += notification.ShowNotification;
		youtuber.UploadVideo();
		youtuber.subscribes -= notification.ShowNotification;
	}
}



