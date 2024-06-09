using System;
using System.Collections.Generic;
using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.java.util {
    internal class ArrayList<T> : IList<T> {
        private readonly System.Collections.Generic.IList<T> _list;

        internal ArrayList() : this(new System.Collections.Generic.List<T>())
        {
        }

        internal ArrayList(System.Collections.Generic.IList<T> list)
        {
            _list = list;
        }

        internal ArrayList(IList<T> list) : this(new System.Collections.Generic.List<T>(FromJava.IterableToEnumerable(list)))
        {
        }

        public ITerator<T> Iterator()
        {
            return ToJava.EnumeratorToIterator(_list.GetEnumerator());
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }

        public int Size()
        {
            return _list.Count;
        }

        public bool Contains(object value)
        {
            return value is T && _list.Contains((T) value);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _list.Count) {
                throw new IndexOutOfBoundsException();
            }

            return _list[index];
        }

        public IList<T> SubList(int fromIndex, int toIndex)
        {
            var list = _list as System.Collections.Generic.List<T>;
            if (list == null) {
                throw new NotImplementedException();
            }

            return new ArrayList<T>(list.GetRange(fromIndex, toIndex - fromIndex));
        }

        public void Add(T value)
        {
            _list.Add(value);
        }

        public T Remove(int index)
        {
            var value = _list[index];
            _list.RemoveAt(index);
            return value;
        }

        public void Set(int index, T value)
        {
            _list[index] = value;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
