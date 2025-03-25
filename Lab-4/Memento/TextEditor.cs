using CTextDocument;
using CTextDocumentMemento;

namespace CTextEditor
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<TextDocumentMemento> _history = new();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void TypeText(string newText)
        {
            Save();
            _document.Content += newText;
        }

        public void ShowDocument()
        {
            _document.Show();
        }

        public void Save()
        {
            _history.Push(new TextDocumentMemento(_document.Content));
            Console.WriteLine("Збережено стан документа.");
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Content = memento.SavedContent;
                Console.WriteLine("Відновлено попередній стан.");
            }
            else
            {
                Console.WriteLine("Немає збережених станів для відкату.");
            }
        }
    }

}