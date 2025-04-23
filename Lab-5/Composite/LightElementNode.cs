using BehavioralPatterns.State;
using BehavioralPatterns.Visitor;

namespace BehavioralPatterns.Composite
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<string> _cssClasses;
        private List<LightNode> _children;
        private int _CountClasses = 0;
        private IElementState _state = new EnabledState();
        public string TagName => _tagName;
        public IReadOnlyList<LightNode> Children => _children;
        private List<LightNode> _children;
        private int _CountClasses = 0;

        public LightElementNode(string tagName)
            : this(tagName, true, false)
        {
        }

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

        public void SetState(IElementState newState)
        {
            _state = newState;
            
        public void AddClass(string className)
        {
            _cssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            _state.AddChild(this, child);
        }

        public void AddClass(string className)
        {
            _state.AddClass(this, className);
            _children.Add(child);
            _CountClasses++;
        }

        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var c in _children) c.Accept(visitor);
        }

        internal void AddChildInternal(LightNode child)
        {
            _children.Add(child);
            _CountClasses++;
        }

        internal void AddClassInternal(string className)
        {
            if (!_cssClasses.Contains(className))
                _cssClasses.Add(className);
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
        }

        public void RemoveClass(string className)
        {
            _cssClasses.Remove(className);
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

        public IReadOnlyList<string> CssClasses => _cssClasses;

        public int getCountClasses()
        {
            return this._CountClasses;
        }
    }
}