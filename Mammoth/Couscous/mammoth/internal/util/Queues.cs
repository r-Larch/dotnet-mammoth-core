using System.Collections.Generic;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Queues {
        internal static java.util.Queue<T> stack<T>()
        {
            return new Stack<T>();
        }
    }

    internal class Stack<T> : java.util.Queue<T> {
        private readonly IList<T> _stack = new System.Collections.Generic.List<T>();

        public Iterator<T> iterator()
        {
            return ToJava.EnumeratorToIterator(_stack.GetEnumerator());
        }

        public void add(T value)
        {
            _stack.Add(value);
        }

        public T remove()
        {
            var index = _stack.Count - 1;
            var value = _stack[index];
            _stack.RemoveAt(index);
            return value;
        }
    }
}
