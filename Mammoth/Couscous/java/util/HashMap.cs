using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.java.util {
    internal class HashMap<TKey, TValue> : AbstractMap<TKey, TValue> {
        private readonly Dictionary<TKey, TValue> _dictionary;

        internal HashMap() : this(new Dictionary<TKey, TValue>())
        {
        }

        internal HashMap(Dictionary<TKey, TValue> dictionary)
        {
            _dictionary = dictionary;
        }

        internal HashMap(IMap<TKey, TValue> map) : this(new Dictionary<TKey, TValue>(map.AsDictionary()))
        {
        }

        public override void Put(TKey key, TValue value)
        {
            _dictionary[key] = value;
        }

        public override bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public override ISet<IMapEntry<TKey, TValue>> EntrySet()
        {
            return new EntrySetImpl(_dictionary);
        }

        public override ICollection<TValue> Values()
        {
            return ToJava.CollectionToCollection(_dictionary.Values);
        }

        public override IOptional<TValue> _lookup(TKey key)
        {
            if (_dictionary.ContainsKey(key)) {
                return new Some<TValue>(_dictionary[key]);
            }

            return None<TValue>.Instance;
        }

        public override IDictionary<TKey, TValue> AsDictionary()
        {
            return _dictionary;
        }

        public override IDictionary AsUntypedDictionary()
        {
            return _dictionary;
        }

        internal class EntrySetImpl : ISet<IMapEntry<TKey, TValue>> {
            private readonly IDictionary<TKey, TValue> _dictionary;

            internal EntrySetImpl(IDictionary<TKey, TValue> dictionary)
            {
                _dictionary = dictionary;
            }

            public ITerator<IMapEntry<TKey, TValue>> Iterator()
            {
                return ToJava.EnumeratorToIterator(_dictionary.Select(entry => Maps.Entry(entry.Key, entry.Value)).GetEnumerator());
            }

            public bool IsEmpty()
            {
                return _dictionary.Count == 0;
            }

            public int Size()
            {
                return _dictionary.Count;
            }

            public bool Contains(object value)
            {
                return value is TKey && _dictionary.ContainsKey((TKey) value);
            }

            public void Add(IMapEntry<TKey, TValue> value)
            {
                throw new UnsupportedOperationException();
            }
        }
    }
}
