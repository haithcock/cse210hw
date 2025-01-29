public class Comment
{
    public string UserName {get; set;}
    public string UserComment {get; set;}

    public Comment(String userName, string userComment)
    {
        UserName = userName;
        UserComment = userComment;
    }


}