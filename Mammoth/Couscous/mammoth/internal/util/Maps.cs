using System.Collections.Generic;
using System.Linq;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Maps {
        internal static IMap<TK, TV> Map<TK, TV>()
        {
            return ToJava.DictionaryToMap(new Dictionary<TK, TV>());
        }

        internal static IMap<TK, TV> Map<TK, TV>(TK key1, TV value1)
        {
            return ToJava.DictionaryToMap(new Dictionary<TK, TV> {
                { key1, value1 }
            });
        }

        internal static IMap<TK, TV> Map<TK, TV>(TK key1, TV value1, TK key2, TV value2)
        {
            return ToJava.DictionaryToMap(new Dictionary<TK, TV> {
                { key1, value1 },
                { key2, value2 }
            });
        }

        internal static IMap<TK, TV> Map<TK, TV>(TK key1, TV value1, TK key2, TV value2, TK key3, TV value3)
        {
            return ToJava.DictionaryToMap(new Dictionary<TK, TV> {
                { key1, value1 },
                { key2, value2 },
                { key3, value3 }
            });
        }

        internal static IMap<TK, TV> ToMap<T, TK, TV>(ITerable<T> iterable, IFunction<T, IMapEntry<TK, TV>> function)
        {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .Select(function.Apply)
                .ToDictionary(entry => entry.GetKey(), entry => entry.GetValue());
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IMap<TK, T> ToMapWithKey<T, TK>(ITerable<T> iterable, IFunction<T, TK> function)
        {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .ToDictionary(function.Apply);
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IMap<TK, java.util.IList<T>> ToMultiMapWithKey<T, TK>(ITerable<T> iterable, IFunction<T, TK> function)
        {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .GroupBy(value => function.Apply(value))
                .ToDictionary(
                    grouping => grouping.Key,
                    grouping => ToJava.ListToList(grouping.ToList()));
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IMap<TK, java.util.IList<TV>> ToMultiMap<T, TK, TV>(ITerable<T> iterable, IFunction<T, IMapEntry<TK, TV>> function)
        {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .Select(element => function.Apply(element))
                .GroupBy(entry => entry.GetKey())
                .ToDictionary(
                    grouping => grouping.Key,
                    grouping => ToJava.ListToList(grouping.Select(entry => entry.GetValue()).ToList()));
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IOptional<TV> Lookup<TK, TV>(IMap<TK, TV> map, TK key)
        {
            return map._lookup(key);
        }

        internal static IMap<TK2, TV> EagerMapKeys<TK1, TK2, TV>(IMap<TK1, TV> map, IFunction<TK1, TK2> function)
        {
            var dictionary = FromJava.MapToDictionary(map)
                .ToDictionary(
                    entry => function.Apply(entry.Key),
                    entry => entry.Value);
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IMap<TK, TV2> EagerMapValues<TK, TV1, TV2>(IMap<TK, TV1> map, IFunction<TV1, TV2> function)
        {
            var dictionary = FromJava.MapToDictionary(map)
                .ToDictionary(
                    entry => entry.Key,
                    entry => function.Apply(entry.Value));
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static IMapEntry<TK, TV> Entry<TK, TV>(TK key, TV value)
        {
            return new MapEntry<TK, TV>(key, value);
        }

        internal static MapBuilder<TK, TV> Builder<TK, TV>()
        {
            return new MapBuilder<TK, TV>();
        }

        internal static IMap<TK, TV> MutableMap<TK, TV>(TK key1, TV value1)
        {
            var map = new HashMap<TK, TV>();
            map.Put(key1, value1);
            return map;
        }

        private class MapEntry<TK, TV> : IMapEntry<TK, TV> {
            private readonly TK _key;
            private readonly TV _value;

            internal MapEntry(TK key, TV value)
            {
                _key = key;
                _value = value;
            }

            public TK GetKey()
            {
                return _key;
            }

            public TV GetValue()
            {
                return _value;
            }

            public override bool Equals(object otherObj)
            {
                var other = otherObj as MapEntry<TK, TV>;
                if (other == null) {
                    return false;
                }

                if (ReferenceEquals(this, other)) {
                    return true;
                }

                return _key.Equals(other._key) && _value.Equals(other._value);
            }

            public override int GetHashCode()
            {
                return _key.GetHashCode() * 17 + _value.GetHashCode();
            }
        }

        internal class MapBuilder<TK, TV> {
            private readonly Dictionary<TK, TV> _values = new();

            public MapBuilder<TK, TV> Put(TK key, TV value)
            {
                _values[key] = value;
                return this;
            }

            public IMap<TK, TV> Build()
            {
                return ToJava.DictionaryToMap(_values);
            }
        }
    }
}
