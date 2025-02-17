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







/*   Goal myFirstGoal = new Goal("Finish Project", "Complete the final project for my course.", 100);  */
