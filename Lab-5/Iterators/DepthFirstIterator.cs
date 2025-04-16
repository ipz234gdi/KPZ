using System;
using System.Collections.Generic;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Iterators
{
    public class DepthFirstIterator : IIterator<LightNode>
    {
        private readonly Stack<IEnumerator<LightNode>> _stack = new();

        public DepthFirstIterator(LightElementNode root)
        {
            _stack.Push(new List<LightNode> { root }.GetEnumerator());
        }

        public bool HasNext()
        {
            while (_stack.Count > 0)
            {
                var top = _stack.Peek();
                if (top.MoveNext()) 
                    return true;
                _stack.Pop();
            }
            return false;
        }

        public LightNode Next()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("No more elements");

            var currentEnumerator = _stack.Peek();
            var current = currentEnumerator.Current;

            if (current is LightElementNode elem)
                _stack.Push(elem.Children.GetEnumerator());

            return current;
        }
    }
}
