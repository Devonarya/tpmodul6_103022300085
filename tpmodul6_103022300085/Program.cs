using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul video tidak boleh null");
        Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Penambahan play count tidak boleh lebih dari 10.000.000");
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

        video.IncreasePlayCount(1000000000);
        Console.WriteLine("\n");
        video.PrintVideoDetails();

    }
}