using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (!string.IsNullOrEmpty(title) && title.Length <= 100)
        {
            this.title = title;
            this.id = GenerateRandomId();
            playCount = 0;
        }
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
        {
            throw new ArgumentOutOfRangeException("Input harus di antara 0 dan 10.000.000.");
        }
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
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

        try
        {
            SayaTubeVideo video = new SayaTubeVideo(judulVideo);
            for (int i = 0; i < 3; i++) 
            {
                video.IncreasePlayCount(5000);
            }
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
