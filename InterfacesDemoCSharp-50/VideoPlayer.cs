namespace InterfacesDemoCSharp_50;

public class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing video..");
    }

    public void Pause()
    {
        Console.WriteLine("Video is paused..");
    }

    public void Stop()
    {
        Console.WriteLine("Video is stopped..");
    }
}