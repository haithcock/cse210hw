using System;

class Program
{
    static void Main(string[] args)
    {
        Video catVideo = new Video();
        catVideo.Title = "About Cats";
        catVideo.Author = "VideoMaker";
        catVideo.Length = 120;

        Comment firstComment = new Comment("Catlover", "Awesome video about cats");
        catVideo.AddComment(firstComment);
    }


}