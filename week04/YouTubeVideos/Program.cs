using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create video instances
            Video video1 = new Video("Learn C# in 10 Minutes", "Levi Larson", 600);
            Video video2 = new Video("Top 10 Coding Tips", "CSe-210", 540);
            Video video3 = new Video("Top 10 gaming Clips", "Gamer Guy", 300);
            Video video4 = new Video("The History of C#", "CompSci", 1200);

            // Add comments to each video
            video1.AddComment(new Comment("Alice", "This was so helpful!"));
            video1.AddComment(new Comment("Bob", "Love the clarity of explanation."));
            video1.AddComment(new Comment("Charlie", "I finally get classes now!"));

            video2.AddComment(new Comment("David", "Tip #5 changed everything!"));
            video2.AddComment(new Comment("Ella", "Great advice for beginners."));
            video2.AddComment(new Comment("Frank", "Can you do one for Python?"));

            video3.AddComment(new Comment("Grace", "Epic."));
            video3.AddComment(new Comment("Henry", "I can't stop laughing."));
            video3.AddComment(new Comment("Irene", "Replay button is broken!"));

            video4.AddComment(new Comment("Jack", "Fascinating topic."));
            video4.AddComment(new Comment("Karen", "Loved the visuals."));
            video4.AddComment(new Comment("Leo", "Would love a part 2!"));

            // Put videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3, video4 };

            // Display all video details
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");
                foreach (Comment _comment in video.GetComments())
                {
                    Console.WriteLine($" - {_comment._commenterName}: {_comment._text}");
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }