public class Word
{
    private string _text;
    private bool _isHiddend;

    public Word(string text)
    {
        _text = text;
        _isHiddend = false;
    }

    public void Hide()
    {
        _isHiddend = true;
    }

    public void Show()
    {
        _isHiddend = false;
    }

    public bool IsHiddend()
    {
        return _isHiddend;
    }

    public string GetDisplayText()
    {
        if (_isHiddend)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

}