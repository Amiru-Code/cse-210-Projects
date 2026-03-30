using System;
class Program
{
    static void Main(string[] args)
    {

        List<Video> VidList = new List<Video>();

        Video video1 = new Video("Sandwiches and what they are", "Larry lepton", 299792);
        Video video2 = new Video("Why birds will take over the world", "Mr Tau", 3141592);
        Video video3 = new Video("What on earth is that frog monitor!?!", "Mr frog guy", 662607015 );
        

        // I'm using the same comments for each video because it's easy to do so and demonstratest the same concept anyway, it wouldn't really be any different
        // if I were to use additional comments.
        Comment comment1 = new Comment("Mr frog guy", "No! Absolutely not!");
        Comment comment2 = new Comment("Paul Derack", "Well you see that is patently false!");
        Comment comment3 = new Comment("Linus Torvalds", "Fedora is the best!");
        Comment comment4 = new Comment("Marie Currie", "You see, separating radium from the surrounding material is quite difficult...");
        
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);

        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);
        video3.AddComment(comment4);

    VidList.Add(video1);
    VidList.Add(video2);
    VidList.Add(video3);

    int i = VidList.Count() - 1;
    while (i >= 0)
        {
            Console.WriteLine($"The Title of this video is {VidList[i].GetTitle()}");
            Console.WriteLine($"The author of the video is {VidList[i].GetAuthor()}");
            Console.WriteLine($"The duration of this video is {VidList[i].GetDuration()} seconds");

            Console.WriteLine($"The number of comments is {VidList[i].NumComment()}");
            Console.WriteLine();
            for ( int x = 0; x < VidList[i].NumComment(); x++)
            {
                //getcommment info returns an entire comment type so I need to use the comment getters to assign my values.
                Comment c = VidList[i].GetCommentInfo()[x];
                Console.WriteLine($"The author of this comment is: {c.GetAuthor()}");
                Console.WriteLine($"The text of the comment is: '{c.GetText()}'");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            i--;
        }
    }
}