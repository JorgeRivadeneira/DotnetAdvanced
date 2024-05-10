using Events;

public class MessageService
{
    public void OnVideoEncoded(object sender, VideoEventArgs args)
    {
        Console.WriteLine("MessageService: Sending a SMS to the user..." + args.Video.Title);
    }
}