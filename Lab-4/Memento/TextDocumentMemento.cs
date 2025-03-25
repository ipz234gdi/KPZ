namespace CTextDocumentMemento
{
    public class TextDocumentMemento
    {
        public string SavedContent { get; }

        public TextDocumentMemento(string content)
        {
            SavedContent = content;
        }
    }

}