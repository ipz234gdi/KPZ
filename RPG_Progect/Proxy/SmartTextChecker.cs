using CSmartTextReader;
using CLogger;
using System.Linq;

namespace CSmartTextChecker
{
    public class SmartTextChecker
    {
        private SmartTextReader _reader;
        Logger logger = new Logger();

        public SmartTextChecker(SmartTextReader reader) {
            _reader = reader;
        }

        public char[][] ReadFile(string path) {
            logger.Log($"Opening file: {path}");
            
            char[][] result = _reader.ReadFile(path);

            logger.Log("File read successfully");

            int totalLines = result.Length;
            int totalCharacters = result.SelectMany(row => row).Count();

            logger.Log($"Total lines: {totalLines}");
            logger.Log($"Total characters: {totalCharacters}");

            return result;
        }

    }
}