using System;
using System.Collections.Generic;
using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.java.util {
    internal class ArrayList<T> : List<T> {
        private readonly IList<T> _list;

        internal ArrayList() : this(new System.Collections.Generic.List<T>())
        {
        }

        internal ArrayList(IList<T> list)
        {
            _list = list;
        }

        internal ArrayList(List<T> list) : this(new System.Collections.Generic.List<T>(FromJava.IterableToEnumerable(list)))
        {
        }

        public Iterator<T> iterator()
        {
            return ToJava.EnumeratorToIterator(_list.GetEnumerator());
        }

        public bool isEmpty()
        {
            return _list.Count == 0;
        }

        public int size()
        {
            return _list.Count;
        }

        public bool contains(object value)
        {
            return value is T && _list.Contains((T) value);
        }

        public T get(int index)
        {
            if (index < 0 || index >= _list.Count) {
                throw new IndexOutOfBoundsException();
            }

            return _list[index];
        }

        public List<T> subList(int fromIndex, int toIndex)
        {
            var list = _list as System.Collections.Generic.List<T>;
            if (list == null) {
                throw new NotImplementedException();
            }

            return new ArrayList<T>(list.GetRange(fromIndex, toIndex - fromIndex));
        }

        public void add(T value)
        {
            _list.Add(value);
        }

        public T remove(int index)
        {
            var value = _list[index];
            _list.RemoveAt(index);
            return value;
        }

        public void set(int index, T value)
        {
            _list[index] = value;
        }

        public void clear()
        {
            _list.Clear();
        }
    }
}
