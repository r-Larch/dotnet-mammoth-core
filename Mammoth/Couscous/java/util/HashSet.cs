using System.Collections.Generic;


namespace Mammoth.Couscous.java.util {
    internal class HashSet<T> : ISet<T> {
        private readonly System.Collections.Generic.ISet<T> _set;

        internal HashSet() : this(new System.Collections.Generic.HashSet<T>())
        {
        }

        internal HashSet(System.Collections.Generic.ISet<T> set)
        {
            _set = set;
        }

        public ITerator<T> Iterator()
        {
            return ToJava.EnumeratorToIterator(_set.GetEnumerator());
        }

        public bool IsEmpty()
        {
            return _set.Count == 0;
        }

        public int Size()
        {
            return _set.Count;
        }

        public bool Contains(object value)
        {
            return value is T && _set.Contains((T) value);
        }

        public void Add(T value)
        {
            _set.Add(value);
        }
    }
}
