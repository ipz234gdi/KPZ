using System.Text.RegularExpressions;
using CSmartTextReader;
using CSmartTextChecker;
using CLogger;

namespace CSmartTextReaderLocker
{
    public class SmartTextReaderLocker
    {
        private SmartTextReader _reader;
        private Regex _denyRegex;
        private Logger logger = new Logger();
        private SmartTextChecker smarttextchecker;

        public SmartTextReaderLocker(SmartTextReader reader, string pattern)
        {
            _reader = reader;
            _denyRegex = new Regex(pattern);
            smarttextchecker = new SmartTextChecker(_reader);
        }

        public void ReadFile(string path)
        {
            if (_denyRegex.IsMatch(path))
            {
                logger.Error($"Access denied! - {_denyRegex}");
            }
            else
            {
                smarttextchecker.ReadFile(path);
            }

        }
    }
}