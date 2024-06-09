using System.Collections.Generic;
using System.IO;
using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous {
    internal static class FromJava {
        internal static IEnumerable<T> IterableToEnumerable<T>(ITerable<T> iterable)
        {
            var iterator = iterable.Iterator();
            while (iterator.HasNext()) {
                yield return iterator.Next();
            }
        }

        internal static IDictionary<TKey, TValue> MapToDictionary<TKey, TValue>(IMap<TKey, TValue> map)
        {
            return map.AsDictionary();
        }
    }

    internal static class ToJava {
        internal static ITerable<T> EnumerableToIterable<T>(IEnumerable<T> enumerator)
        {
            return new IterableWrapper<T>(enumerator);
        }

        internal static ITerator<T> EnumeratorToIterator<T>(IEnumerator<T> enumerator)
        {
            return new EnumeratorToIteratorAdapter<T>(enumerator);
        }

        internal static IMap<TKey, TValue> DictionaryToMap<TKey, TValue>(IDictionary<TKey, TValue> dictionary)
        {
            return new HashMap<TKey, TValue>(new Dictionary<TKey, TValue>(dictionary));
        }

        internal static IMap<TKey, TValue> DictionaryToMap<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            return new HashMap<TKey, TValue>(dictionary);
        }

        internal static java.util.IList<T> ListToList<T>(System.Collections.Generic.IList<T> list)
        {
            return new ArrayList<T>(list);
        }

        internal static INputStream StreamToInputStream(Stream stream)
        {
            return new StreamToInputStreamAdapter(stream);
        }

        internal static java.util.ICollection<T> CollectionToCollection<T>(System.Collections.Generic.ICollection<T> collection)
        {
            return new CollectionToCollectionAdapter<T>(collection);
        }

        private class IterableWrapper<T> : ITerable<T> {
            private readonly IEnumerable<T> _enumerable;

            internal IterableWrapper(IEnumerable<T> enumerable)
            {
                _enumerable = enumerable;
            }

            public ITerator<T> Iterator()
            {
                return EnumeratorToIterator(_enumerable.GetEnumerator());
            }
        }

        private class EnumeratorToIteratorAdapter<T> : ITerator<T> {
            private readonly IEnumerator<T> _enumerator;
            private bool _hasNext;
            private bool _ready;

            internal EnumeratorToIteratorAdapter(IEnumerator<T> enumerator)
            {
                _enumerator = enumerator;
                _ready = false;
            }

            public bool HasNext()
            {
                MakeReady();
                return _hasNext;
            }

            public T Next()
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

        private class StreamToInputStreamAdapter : INputStream {
            internal StreamToInputStreamAdapter(Stream stream)
            {
                Stream = stream;
            }

            public Stream Stream { get; }
        }

        private class CollectionToCollectionAdapter<T> : java.util.ICollection<T> {
            private readonly System.Collections.Generic.ICollection<T> _collection;

            internal CollectionToCollectionAdapter(System.Collections.Generic.ICollection<T> collection)
            {
                _collection = collection;
            }

            public bool IsEmpty()
            {
                return _collection.Count == 0;
            }

            public int Size()
            {
                return _collection.Count;
            }

            public bool Contains(object value)
            {
                return value is T && _collection.Contains((T) value);
            }

            public ITerator<T> Iterator()
            {
                return EnumeratorToIterator(_collection.GetEnumerator());
            }

            public void Add(T value)
            {
                throw new UnsupportedOperationException();
            }
        }
    }
}
