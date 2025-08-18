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

    /// Parses a string of comments (separated by ~) 
    /// and adds them to the video.
    /// Format: "Name:Comment~Name:Comment"
    public void GetComment(string text)
    {
        string[] comments = text.Split("~");
        foreach (string item in comments)
        {
            string[] attributes = item.Split(":");
            if (attributes.Length == 2)
            {
                _comments.Add(new Comment(attributes[0], attributes[1]));
            }
        }
    }

     /// Displays video details and its comments.
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

