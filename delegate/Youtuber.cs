namespace Delegate;
public delegate void Subscribes(string text);
public class Youtuber 
{
	public Subscribes subscribes;
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video..");
		SentNotification("Video Baru nih..");
	}
	public void SentNotification (string title)
	{
		subscribes(title);
	}
}