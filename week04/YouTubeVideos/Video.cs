public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}

    public List<Comment> VideoComments { get; set; } = new List<Comment>();
    
    public void AddComment(Comment newComment) /*I think this code takes a new comment and puts it in our container (list) of comments    */
    {                                          
        VideoComments.Add(newComment);
    }
    public int GetTotalCommentCount()
    {
        return VideoComments.Count;
    }



}







/*
Step 2️⃣: Add a Method to Video to Get the Number of Comments

Now, we need a method inside Video that returns the number of comments.
🛠 Your Task:

    Inside Video, create a method called GetCommentCount().
    This method should:
        Return an int (the total number of comments in the Comments list).

Hint:

How do you get the size of a List<> in C#? Think about how you'd retrieve the number of items in Comments.
*/