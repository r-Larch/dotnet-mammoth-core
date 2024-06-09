using System.Collections.Generic;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Queues {
        internal static java.util.IQueue<T> Stack<T>()
        {
            return new Stack<T>();
        }
    }

    internal class Stack<T> : java.util.IQueue<T> {
        private readonly System.Collections.Generic.IList<T> _stack = new System.Collections.Generic.List<T>();

        public ITerator<T> Iterator()
        {
            return ToJava.EnumeratorToIterator(_stack.GetEnumerator());
        }

        public void Add(T value)
        {
            _stack.Add(value);
        }

        public T Remove()
        {
            var index = _stack.Count - 1;
            var value = _stack[index];
            _stack.RemoveAt(index);
            return value;
        }
    }
}
