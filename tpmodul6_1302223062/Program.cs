using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details:\nID: {id}\nTitle: {title}\nPlay Count: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string namaPraktikan = "[Francisca_PRAKTIKAN]";
        string judulVideo = $"Tutorial Design By Contract - {namaPraktikan}";

        SayaTubeVideo video = new SayaTubeVideo(judulVideo);
        video.IncreasePlayCount(5); 
        video.PrintVideoDetails();
    }
}
