
namespace CFileWriter
{
    public class FileWriter
    {
        private string _filePath = "log.txt";

        public void Write(string text)
        {
            File.AppendAllText(this._filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(this._filePath, Environment.NewLine + text);
        }
    }
}