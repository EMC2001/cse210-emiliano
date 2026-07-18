using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

//Video 1 video and comments
        Video video1 = new Video();
        video1._title = "Rocket League Final!?";
        video1._author = "EMCrusher2001";
        video1._length = 360;
        _videos.Add(video1);

        Comment comment1 = new Comment();
        comment1._user = "Rocko";
        comment1._commentText = "That was sick";
        video1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._user = "Alex";
        comment2._commentText = "That was rad I wish I had the same sucess";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._user = "Damian";
        comment3._commentText = "Brom matching is soooo hard";
        video1._comments.Add(comment3);

        Comment comment4 = new Comment();
        comment4._user = "Rudolph";
        comment4._commentText = "I hate this guy fr fr";
        video1._comments.Add(comment4);

//Video 2 video and comments
        Video video2 = new Video();
        video2._title = "Tacos and More Tacos";
        video2._author = "Tacolover";
        video2._length = 600;
        _videos.Add(video2);

        Comment comment5 = new Comment();
        comment5._user = "Rocko";
        comment5._commentText = "I would destroy those tacos fr fr bro, ngl";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._user = "Meagn";
        comment6._commentText = "Tbh I've seen better";
        video2._comments.Add(comment6);

        Comment comment7 = new Comment();
        comment7._user = "Megan";
        comment7._commentText = "Bro chorizo tacos are insane";
        video2._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._user = "Doroteo";
        comment8._commentText = "I looooooove your voice bruh, you should start a podcast with Joe Rogan";
        video2._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._user = "Doroteo";
        comment9._commentText = "Actually I hate it :p";
        video2._comments.Add(comment9);



//Video 3 video and comments
        Video video3 = new Video();
        video3._title = "My new fake leg";
        video3._author = "DRLeg";
        video3._length = 240;
        _videos.Add(video3);

        Comment comment10 = new Comment();
        comment10._user = "Doroteo";
        comment10._commentText = "Actually I hate it :p";
        video3._comments.Add(comment10);

        Comment comment11 = new Comment();
        comment11._user = "Doroteo";
        comment11._commentText = "Just kidding I don't hate it";
        video3._comments.Add(comment11);

        Comment comment12 = new Comment();
        comment12._user = "Doroteo";
        comment12._commentText = "Looking cute haha";
        video3._comments.Add(comment12);

//Video 4 video and comments
        Video video4 = new Video();
        video4._title = "Just eat it bro";
        video4._author = "BroskiBro";
        video4._length = 420;
        _videos.Add(video4);

        Comment comment13 = new Comment();
        comment13._user = "Mario";
        comment13._commentText = "Disgusting";
        video4._comments.Add(comment13);

        Comment comment14 = new Comment();
        comment14._user = "Markiplier";
        comment14._commentText = "Yooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        video4._comments.Add(comment14);

        Comment comment15 = new Comment();
        comment15._user = "Carlitos";
        comment15._commentText = "giving me flashbacks lol";
        video4._comments.Add(comment15);

        Comment comment16 = new Comment();
        comment16._user = "YoMMA";
        comment16._commentText = "I almost threw up bruh";
        video4._comments.Add(comment16);

        Comment comment17 = new Comment();
        comment17._user = "Doroteo";
        comment17._commentText = "I wish I had a bro like that";
        video4._comments.Add(comment17);

        Comment comment18 = new Comment();
        comment18._user = "Corneo";
        comment18._commentText = "Ay ayayayaya canta y no llores cuh.";
        video4._comments.Add(comment18);

        foreach(Video video in _videos)
        {
            video.DisplayVideo();
        }

    }
}