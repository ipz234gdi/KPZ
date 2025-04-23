using System;
using System.Collections.Generic;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Iterators
{
    public class BreadthFirstIterator : IIterator<LightNode>
    {
        private readonly Queue<LightNode> _queue = new();

        public BreadthFirstIterator(LightElementNode root) => _queue.Enqueue(root);

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            if (!HasNext()) throw new InvalidOperationException();
            var node = _queue.Dequeue();
            if (node is LightElementNode elem)
                foreach (var child in elem.Children)
                    _queue.Enqueue(child);
            return node;
        }
    }
}
