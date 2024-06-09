using System.Collections.Generic;
using System.IO;
using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous {
    internal static class FromJava {
        internal static IEnumerable<T> IterableToEnumerable<T>(Iterable<T> iterable)
        {
            var iterator = iterable.iterator();
            while (iterator.hasNext()) {
                yield return iterator.next();
            }
        }

        internal static IDictionary<TKey, TValue> MapToDictionary<TKey, TValue>(Map<TKey, TValue> map)
        {
            return map.AsDictionary();
        }
    }

    internal static class ToJava {
        internal static Iterable<T> EnumerableToIterable<T>(IEnumerable<T> enumerator)
        {
            return new IterableWrapper<T>(enumerator);
        }

        internal static Iterator<T> EnumeratorToIterator<T>(IEnumerator<T> enumerator)
        {
            return new EnumeratorToIteratorAdapter<T>(enumerator);
        }

        internal static Map<TKey, TValue> DictionaryToMap<TKey, TValue>(IDictionary<TKey, TValue> dictionary)
        {
            return new HashMap<TKey, TValue>(new Dictionary<TKey, TValue>(dictionary));
        }

        internal static Map<TKey, TValue> DictionaryToMap<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            return new HashMap<TKey, TValue>(dictionary);
        }

        internal static java.util.List<T> ListToList<T>(IList<T> list)
        {
            return new ArrayList<T>(list);
        }

        internal static InputStream StreamToInputStream(Stream stream)
        {
            return new StreamToInputStreamAdapter(stream);
        }

        internal static Collection<T> CollectionToCollection<T>(ICollection<T> collection)
        {
            return new CollectionToCollectionAdapter<T>(collection);
        }

        private class IterableWrapper<T> : Iterable<T> {
            private readonly IEnumerable<T> _enumerable;

            internal IterableWrapper(IEnumerable<T> enumerable)
            {
                _enumerable = enumerable;
            }

            public Iterator<T> iterator()
            {
                return EnumeratorToIterator(_enumerable.GetEnumerator());
            }
        }

        private class EnumeratorToIteratorAdapter<T> : Iterator<T> {
            private readonly IEnumerator<T> _enumerator;
            private bool _hasNext;
            private bool _ready;

            internal EnumeratorToIteratorAdapter(IEnumerator<T> enumerator)
            {
                _enumerator = enumerator;
                _ready = false;
            }

            public bool hasNext()
            {
                MakeReady();
                return _hasNext;
            }

            public T next()
            {
                MakeReady();
                if (_hasNext) {
                    _ready = false;
                    return _enumerator.Current;
                }

                throw new NoSuchElementException();
            }

            private void MakeReady()
            {
                if (!_ready) {
                    MoveNext();
                }
            }

            private void MoveNext()
            {
                _hasNext = _enumerator.MoveNext();
                _ready = true;
            }
        }

        private class StreamToInputStreamAdapter : InputStream {
            internal StreamToInputStreamAdapter(Stream stream)
            {
                Stream = stream;
            }

            public Stream Stream { get; }
        }

        private class CollectionToCollectionAdapter<T> : Collection<T> {
            private readonly ICollection<T> _collection;

            internal CollectionToCollectionAdapter(ICollection<T> collection)
            {
                _collection = collection;
            }

            public bool isEmpty()
            {
                return _collection.Count == 0;
            }

            public int size()
            {
                return _collection.Count;
            }

            public bool contains(object value)
            {
                return value is T && _collection.Contains((T) value);
            }

            public Iterator<T> iterator()
            {
                return EnumeratorToIterator(_collection.GetEnumerator());
            }

            public void add(T value)
            {
                throw new UnsupportedOperationException();
            }
        }
    }
}
