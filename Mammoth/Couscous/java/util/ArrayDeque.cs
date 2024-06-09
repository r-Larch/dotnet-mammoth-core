using System.Collections.Generic;


namespace Mammoth.Couscous.java.util {
    internal class ArrayDeque<T> : IDeque<T> {
        private readonly System.Collections.Generic.IList<T> _list = new System.Collections.Generic.List<T>();

        public int Size()
        {
            return _list.Count;
        }

        public T GetFirst()
        {
            if (_list.Count > 0) {
                return _list[0];
            }

            throw new NoSuchElementException();
        }

        public T GetLast()
        {
            if (_list.Count > 0) {
                return _list[_list.Count - 1];
            }

            throw new NoSuchElementException();
        }

        public void Add(T value)
        {
            _list.Add(value);
        }

        public T RemoveLast()
        {
            var value = GetLast();
            _list.RemoveAt(_list.Count - 1);
            return value;
        }
    }
}
