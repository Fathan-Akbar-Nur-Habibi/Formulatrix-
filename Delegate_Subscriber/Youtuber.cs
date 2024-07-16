namespace Delegate_Subscriber;

public class Youtuber
{
	// subscriber, notifikasim email dan sms dijadikan 1
	public Subscriber subscriber;
	public Email email; 
	public SMS sMS ;
	public notifikas notifikas ;
	public void UploadVideo ()
	{
		Console.WriteLine("Uploading video..");
		SentNotification("Video Baru nih..");
	}
}
