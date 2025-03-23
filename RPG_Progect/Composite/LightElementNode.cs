using CLightNode;

namespace CLightElementNode
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<string> _cssClasses;
        private List<LightNode> _children;
        private int _CountClasses = 0;

        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            _tagName = tagName;
            _isBlock = isBlock;
            _isSelfClosing = isSelfClosing;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
        }

        // Task6
        public LightElementNode(LightElementNode template)
        {
            _tagName = template._tagName;
            _isBlock = template._isBlock;
            _isSelfClosing = template._isSelfClosing;
            _cssClasses = new List<string>(template._cssClasses);
            _children = new List<LightNode>();
        }


        public void AddClass(string className)
        {
            _cssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
            _CountClasses++;
        }

        private string Indent(int level)
        {
            return new string(' ', level * 4);
        }

        public override string OuterHTML()
        {
            return OuterHTML(0);
        }

        public string OuterHTML(int indentLevel)
        {
            var indent = Indent(indentLevel);
            var classAttr = _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";

            if (_isSelfClosing)
                return $"{indent}<{_tagName}{classAttr} />\n";

            string inner = string.Join("", _children.Select(child => (child is LightElementNode elementChild) ? elementChild.OuterHTML(indentLevel + 1) : Indent(indentLevel + 1) + child.OuterHTML() + "\n"));

            return $"{indent}<{_tagName}{classAttr}>\n{inner}{indent}</{_tagName}>\n";
        }

        public override string InnerHTML()
        {
            return string.Join("", _children.Select(child => child.OuterHTML()));
        }

        public int getCountClasses()
        {
            return this._CountClasses;
        }
    }
}