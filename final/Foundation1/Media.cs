using System;
using System.Collections.Generic;

// Video class inheriting from Media
class Video : Media
{
    public int Length { get; set; }// Public property to store the length of the video
    private List<Comment> comments;// Private field to store the comments on the video

    public Video()
    {
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        // Add a comment to the video
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        // Return the number of comments on the video
        return comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }

        Console.WriteLine();
    }
}