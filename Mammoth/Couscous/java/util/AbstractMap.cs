using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Mammoth.Couscous.java.util {
    internal abstract class AbstractMap<TKey, TValue> : IMap<TKey, TValue> {
        public abstract void Put(TKey key, TValue value);
        public abstract bool ContainsKey(TKey key);
        public abstract ISet<IMapEntry<TKey, TValue>> EntrySet();
        public abstract ICollection<TValue> Values();

        public abstract IOptional<TValue> _lookup(TKey key);
        public abstract IDictionary<TKey, TValue> AsDictionary();
        public abstract IDictionary AsUntypedDictionary();

        public override bool Equals(object other)
        {
            var otherMap = other as IMap;
            if (otherMap == null) {
                return false;
            }

            return Equals(otherMap);
        }

        public bool Equals(IMap other)
        {
            var first = AsUntypedDictionary();
            var second = other.AsUntypedDictionary();
            return
                first.Count == second.Count &&
                first.Keys.Cast<object>().All(key => second.Contains(key) && first[key].Equals(second[key]));
        }

        public override int GetHashCode()
        {
            throw new NotSupportedException();
        }
    }
}
