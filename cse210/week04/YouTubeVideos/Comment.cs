public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    /// Displays the comment with author name and text.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"comment: {_text}");
    }
}