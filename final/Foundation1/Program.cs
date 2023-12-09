using System;


class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("test", 100, "luke");
        video.DisplayVideo();
        video.DisplayNumComments();
        video.GetElementForList();

        Video video1 = new Video("test1", 200, "luke1");
        video1.DisplayVideo();
        video1.DisplayNumComments();
        video1.GetElementForList();

        Video video2 = new Video("test2", 300, "luke2");
        video2.DisplayVideo();
        video2.DisplayNumComments();
        video2.GetElementForList();

    }
}