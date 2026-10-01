using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Unboxing the Latest Phone", "TechReviewer", 600);
        video1.AddComment(new Comment("Alice", "Great review, very helpful!"));
        video1.AddComment(new Comment("Bob", "I was waiting for this video."));
        video1.AddComment(new Comment("Charlie", "Can you compare it with the previous model?"));

        Video video2 = new Video("Cooking Pasta Like a Pro", "ChefMarco", 480);
        video2.AddComment(new Comment("Diana", "This recipe looks delicious!"));
        video2.AddComment(new Comment("Ethan", "What type of pasta do you recommend?"));
        video2.AddComment(new Comment("Fiona", "I tried this and it was amazing."));

        Video video3 = new Video("Learning C# Basics", "CodeMaster", 900);
        video3.AddComment(new Comment("George", "Finally understood classes!"));
        video3.AddComment(new Comment("Hannah", "Thanks for the clear explanation."));
        video3.AddComment(new Comment("Ian", "Can you make a video on inheritance?"));

        Video video4 = new Video("Travel Vlog: Paris", "WanderlustJess", 720);
        video4.AddComment(new Comment("Julia", "Paris looks beautiful in this video!"));
        video4.AddComment(new Comment("Kevin", "Adding this to my travel list."));
        video4.AddComment(new Comment("Laura", "What camera do you use?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}