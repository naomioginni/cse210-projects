using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Rice", "Chef Maria", 480);
        video1.AddComment(new Comment("Alex", "This helped me so much, thanks!"));
        video1.AddComment(new Comment("Jamie", "Never knew about the rinse step."));
        video1.AddComment(new Comment("Sam", "Great video, very clear instructions."));

        Video video2 = new Video("Learn Guitar Basics", "Rocky Rivera", 900);
        video2.AddComment(new Comment("Taylor", "Finally understand chord changes."));
        video2.AddComment(new Comment("Morgan", "Can you do a follow up video?"));
        video2.AddComment(new Comment("Casey", "Subscribed after watching this."));
        video2.AddComment(new Comment("Riley", "The pacing was perfect for beginners."));

        Video video3 = new Video("Intro to Photography", "Lena Photo", 620);
        video3.AddComment(new Comment("Drew", "Loved the lighting tips."));
        video3.AddComment(new Comment("Jordan", "My photos already look better."));
        video3.AddComment(new Comment("Avery", "More editing tutorials please!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}