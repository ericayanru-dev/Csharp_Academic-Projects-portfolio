public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void GetComment(string text)
    {
        string[] comments = text.Split("~");
        foreach (string item in comments)
        {
            string[] attributes = item.Split(":");

            _comments.Add(new Comment(attributes[0], attributes[1]));
        }
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine();
        Console.WriteLine($"Number of Comments: {_comments.Count()}");
        foreach (Comment item in _comments)
        {
            item.Display();
        }
    }
}

