using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    { 
        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }

    public static void Main(string[] args)
    {

        SayaTubeVideo video = new SayaTubeVideo("Devon Arya Daniswara");

        video.PrintVideoDetails();

        video.IncreasePlayCount(10);

        Console.WriteLine("\n");
        video.PrintVideoDetails();
    }
}