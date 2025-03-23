namespace CSmartTextReader
{
    public class SmartTextReader
    {
        public char[][] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            char[][] result = lines.Select(line => line.ToCharArray()).ToArray();
            return result;
        }
    }

}