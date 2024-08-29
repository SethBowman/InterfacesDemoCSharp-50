namespace InterfacesDemoCSharp_50;

public class AudioPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing audio..");
    }

    public void Pause()
    {
        Console.WriteLine("Audio is paused..");
    }

    public void Stop()
    {
        Console.WriteLine("Audio is stopped..");
    }
}