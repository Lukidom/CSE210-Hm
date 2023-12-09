class Video
{
    public string Title;

    public string Author;

    public int Length;

    public void GetElementForList()
    {
        List<Comments> Additions = new List<Comments>();
        Comments comment1 = new Comments("luke", "text of comment");
        Comments comment2 = new Comments("john", "another text of comment");
        Comments comment3 = new Comments("mary", "text of file");
        Additions.Add(comment1);
        Additions.Add(comment2);
        Additions.Add(comment3);
        foreach (Comments item in Additions)
        {
            Console.WriteLine($"{item.CommentText} - {item.CommentsName}");

        }

    }


    

    int NumComments = 3;

    public Video(string title, int length, string author)
    {
        Title = title;
        Author = author;
        Length = length;

    }

    public void DisplayVideo()
    {
            Console.WriteLine($"{Title} - {Length} - {Author}");
    }

    public void DisplayNumComments()
    {
        Console.WriteLine(NumComments);
    }
    
}