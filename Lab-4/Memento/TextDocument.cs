namespace CTextDocument{
    public class TextDocument
{
    public string Content { get; set; }

    public TextDocument(string content = "")
    {
        Content = content;
    }

    public void Show()
    {
        Console.WriteLine($"Поточний текст: \"{Content}\"");
    }
}

}