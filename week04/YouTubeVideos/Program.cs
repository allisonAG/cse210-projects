using System;

class Program
{
    public static List<Video> _videos = new List<Video>();
    static void Main(string[] args)
    {
        //Video 1
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Sara Murphy";
        video1Comment1._text = "Such a great product. I started seing changes since week 2.";

        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Amanda Swift";
        video1Comment2._text = "I'm very happy with the product.";

        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Alice Webb";
        video1Comment3._text = "Amazing product.";

        Video video1 = new Video();

        video1._title = "New Glycolic Acid Serum";
        video1._author = "Allison Smith";
        video1._length = 340;
        video1.GetNumberOfComments();
        video1._comments.Add(video1Comment1);
        video1._comments.Add(video1Comment2);
        video1._comments.Add(video1Comment3);

        //video1.Display();

        // Video 2

        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Lana Smith";
        video2Comment1._text = "Amazing. Best eye cream I have ever tried.";

        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Anya Goth";
        video2Comment2._text = "I'm very happy with this product.";

        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Mia Badwan";
        video2Comment3._text = "You need to buy this eye cream! I've seen amazing results.";

        Video video2 = new Video();

        video2._title = "Retinal and Ginseng Eye Cream";
        video2._author = "Sabrina Pratt";
        video2._length = 503;
        video2.GetNumberOfComments();
        video2._comments.Add(video2Comment1);
        video2._comments.Add(video2Comment2);
        video2._comments.Add(video2Comment3);

        //video2.Display();

        // Video 3
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Emily Carter";
        video3Comment1._text = "I've been using it for a week now and my skin feels amazing. Not greasy at all!";

        Comment video3Comment2 = new Comment();
        video3Comment2._name = "James Whitaker";
        video3Comment2._text = "The scent is so subtle and fresh. I really love it.";

        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Sophie Bennett";
        video3Comment3._text = "Definitely going to repurchase. It's become part of my daily routine.";

        Video video3 = new Video();

        video3._title = "Trying our new sunscreen";
        video3._author = "Hailey Shields";
        video3._length = 620;
        video3.GetNumberOfComments();
        video3._comments.Add(video3Comment1);
        video3._comments.Add(video3Comment2);
        video3._comments.Add(video3Comment3);

        //video3.Display();

        //Adding videos to a list
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            video.Display();
        }


    }
}