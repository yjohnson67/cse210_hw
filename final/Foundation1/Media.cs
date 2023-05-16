using System;
using System.Collections.Generic;

// Video class inheriting from Media
class Video : Media
{
    public int Length { get; set; }
    private List<Comment> comments;

    public Video()
    {
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
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