using CLightElementNode;

namespace CFlyweightFactory
{
    public class FlyweightFactory
    {
        private Dictionary<string, LightElementNode> _cache = new();

        private string GetKey(string tag, bool isBlock, bool isSelfClosing) => $"{tag}:{isBlock}:{isSelfClosing}";
        
        public LightElementNode GetElement(string tag, bool isBlock, bool isSelfClosing)
        {
            string key = GetKey(tag, isBlock, isSelfClosing);
            if (!_cache.ContainsKey(key))
            {
                _cache[key] = new LightElementNode(tag, isBlock, isSelfClosing);
            }
            return _cache[key];
        }

        public int CacheCount => _cache.Count;
    }
}