using CFlyweightFactory;
using CLightElementNode;
using CLightTextNode;

namespace CBookToHTMLConverter
{
    public class BookToHTMLConverter
    {
        private FlyweightFactory _factory;

        public BookToHTMLConverter(FlyweightFactory factory)
        {
            _factory = factory;
        }

        public LightElementNode Convert(string[] lines)
        {
            var root = new LightElementNode("div", true, false);

            for (int i = 0; i < lines.Length; i++)
            {
                string rawLine = lines[i];
                string line = rawLine.TrimEnd();
                // Console.WriteLine($"[{rawLine}]");

                string tag;
                if (i == 0)
                    tag = "h1";
                else if (!string.IsNullOrEmpty(rawLine) && char.IsWhiteSpace(rawLine[0]))
                    tag = "blockquote";
                else if (line.Length < 20)
                    tag = "h2";
                else
                    tag = "p";

                var template = _factory.GetElement(tag, true, false);
                var tagNode = new LightElementNode(template);

                tagNode.AddChild(new LightTextNode(line));
                root.AddChild(tagNode);
            }

            return root;
        }
    }
}