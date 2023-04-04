using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("@TheSoccerFanatic", "Just amazing!");
        Comment comment2 = new Comment("@TheCornerKicker", "Impressive!");
        Comment comment3 = new Comment("@ArtisticDreamer77", "GOAT");
        Video video1 = new Video("Top 10 Goals", "Goal Scorer", 150);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment("@BallMaster99", "This is absolutely incredble!");
        Comment comment5 = new Comment("@NetBreaker8", "Wow, I'm blown away by this!");
        Comment comment6 = new Comment("@GoalScorer7", "Speechless!");
        Video video2 = new Video("Soccer Skills and Tricks", "TheSoccerGuru", 145);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Comment comment7 = new Comment("@TheSoccerAce", "I'm in awe of how amazing this is!");
        Comment comment8 = new Comment("@GoldenBootWinner", "I can't believe how incredible this is!");
        Comment comment9 = new Comment("@TheSoccerAddict", "I'm amazed by how talented they are!");
        Video video3 = new Video("Soccer Freestly", "TheSoccerNinja", 245);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}