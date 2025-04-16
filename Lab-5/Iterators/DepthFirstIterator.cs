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
                    return true;    // ми зрушили курсор і є поточний елемент
                _stack.Pop();      // цей енум закінчився — знімаємо зі стеку
            }
            return false;
        }

        public LightNode Next()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("No more elements");

            // Ми припускаємо, що HasNext() вже зрушив курсор на валідний Current
            var currentEnumerator = _stack.Peek();
            var current = currentEnumerator.Current;

            // Якщо це вузол із дітьми — додаємо їх енум у стек
            if (current is LightElementNode elem)
                _stack.Push(elem.Children.GetEnumerator());

            return current;
        }
    }
}
