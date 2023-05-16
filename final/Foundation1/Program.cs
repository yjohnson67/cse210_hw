using System;
using System.Collections.Generic;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and populate videos with comments
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 180
        };

        video1.AddComment(new Comment { Name = "User1", Text = "Comment 1" });
        video1.AddComment(new Comment { Name = "User2", Text = "Comment 2" });
        video1.AddComment(new Comment { Name = "User3", Text = "Comment 3" });

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 240
        };

        video2.AddComment(new Comment { Name = "User4", Text = "Comment 4" });
        video2.AddComment(new Comment { Name = "User5", Text = "Comment 5" });
        video2.AddComment(new Comment { Name = "User6", Text = "Comment 6" });

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);

        // Display details of each video
        foreach (var video in videos)
        {
            video.DisplayDetails();
        }
    }
}