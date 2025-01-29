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
        Comment secondComment = new Comment("lee234", "Nice. Cat videos are great.");
        catVideo.AddComment(firstComment);
        Comment thirdComment = new Comment("crazycatlady", "This is why I taxadermy my pets");
        catVideo.AddComment(firstComment);

        Video bestVideo = new Video();
        bestVideo.Title = "New Stable Diffusion";
        bestVideo.Author = "OpenAI";
        bestVideo.Length = 30;

        Comment seventhComment = new Comment("NotElonMusk", "Still not as good as Grok.");
        bestVideo.AddComment(firstComment);
        Comment eigthComment = new Comment("user42069", "LIT");
        bestVideo.AddComment(firstComment);
        Comment ninthComment = new Comment("bestcomrade", "This will change everything!");
        bestVideo.AddComment(firstComment);


        Video paulVideo = new Video();
        paulVideo.Title = "Im Sick and Tired of you folks in Corinth";
        paulVideo.Author = "Apostle_Paul";
        paulVideo.Length = 62;


        Comment tenthComment = new Comment("corinthians", "yOu wOuLdN't uNdErStAnD oLd mAn");
        paulVideo.AddComment(firstComment);
        Comment eleventhComment = new Comment("Lucifer22", "plz stop");
        paulVideo.AddComment(firstComment);
        Comment twelfthComment = new Comment("happybasket", "Go off, King");
        paulVideo.AddComment(firstComment);

        Console.WriteLine($"Title: {catVideo.Title}");
        Console.WriteLine($"Author: {catVideo.Author}");
        Console.WriteLine($"Length: {catVideo.Length} seconds");
        Console.WriteLine($"Title: {bestVideo.Title}");
        Console.WriteLine($"Author: {bestVideo.Author}");
        Console.WriteLine($"Length: {bestVideo.Length} seconds");
        Console.WriteLine($"Title: {paulVideo.Title}");
        Console.WriteLine($"Author: {paulVideo.Author}");
        Console.WriteLine($"Length: {paulVideo.Length} seconds");
    }


}