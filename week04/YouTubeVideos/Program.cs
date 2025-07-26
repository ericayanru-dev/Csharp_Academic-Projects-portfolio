using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "Eric Ayanru", 600);
        video1.GetComment("Alice:Great explanation!~Bob:Thanks, this helped.~Charlie:Please make a sequel.");
        videos.Add(video1);

        Video video2 = new Video("Python Tutorial", "John Doe", 1200);
        video2.GetComment("Jane:Very clear.~Mike:Loved it.~Sam:More examples please!");
        videos.Add(video2);

        Video video3 = new Video("SQL Basics", "Mary Smith", 900);
        video3.GetComment("Tom:This was hard but useful.~Lucy:Excellent tutorial.~Kevin:Keep it up!");
        videos.Add(video3);
        
        foreach (Video item in videos)
        {
            item.Display();
        }
    }
}