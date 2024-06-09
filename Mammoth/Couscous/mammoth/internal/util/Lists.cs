using System.Linq;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Lists {
        internal static IList<T> List<T>(params T[] values)
        {
            return ToJava.ListToList(values);
        }

        internal static IList<T> ToList<T>(ITerable<T> iterable)
        {
            return ToJava.ListToList(FromJava.IterableToEnumerable(iterable).ToList());
        }

        internal static IList<T> EagerFilter<T>(ITerable<T> iterable, IPredicate<T> function)
        {
            var result = FromJava.IterableToEnumerable(iterable)
                .Where(function.Test)
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<TU> EagerMap<T, TU>(ITerable<T> iterable, IFunction<T, TU> function)
        {
            var result = FromJava.IterableToEnumerable(iterable)
                .Select(function.Apply)
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<TU> EagerMapWithIndex<T, TU>(ITerable<T> iterable, IBiFunction<int, T, TU> function)
        {
            var result = FromJava.IterableToEnumerable(iterable)
                .Select((value, index) => function.Apply(index, value))
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<TU> EagerFlatMap<T, TU>(ITerable<T> iterable, IFunction<T, ITerable<TU>> function)
        {
            var result = FromJava.IterableToEnumerable(iterable)
                .SelectMany(element => FromJava.IterableToEnumerable(function.Apply(element)))
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<T> Cons<T>(T head, ITerable<T> tail)
        {
            var result = new[] { head }
                .Concat(FromJava.IterableToEnumerable(tail))
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<T> EagerConcat<T>(ITerable<T> first, ITerable<T> second)
        {
            var result = FromJava.IterableToEnumerable(first)
                .Concat(FromJava.IterableToEnumerable(second))
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<T> EagerConcat<T>(ITerable<T> first, ITerable<T> second, ITerable<T> third)
        {
            var result = FromJava.IterableToEnumerable(first)
                .Concat(FromJava.IterableToEnumerable(second))
                .Concat(FromJava.IterableToEnumerable(third))
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IList<T> OrderedBy<T, TR>(ITerable<T> iterable, IFunction<T, TR> getKey)
        {
            var result = FromJava.IterableToEnumerable(iterable)
                .OrderBy(getKey.Apply)
                .ToList();
            return ToJava.ListToList(result);
        }

        internal static IOptional<T> TryGetFirst<T>(IList<T> list)
        {
            if (list.IsEmpty()) {
                return None<T>.Instance;
            }

            return new Some<T>(list.Get(0));
        }

        internal static IOptional<T> TryGetLast<T>(IList<T> list)
        {
            if (list.IsEmpty()) {
                return None<T>.Instance;
            }

            return new Some<T>(list.Get(list.Size() - 1));
        }

        internal static ITerable<T> Reversed<T>(IList<T> list)
        {
            return new ReversedList<T>(list);
        }

        private class ReversedList<T> : ITerable<T> {
            private readonly IList<T> _list;

            internal ReversedList(IList<T> list)
            {
                _list = list;
            }

            public ITerator<T> Iterator()
            {
                return new ReverseIterator<T>(_list);
            }
        }

        private class ReverseIterator<T> : ITerator<T> {
            private readonly IList<T> _list;
            private int _nextIndex;

            internal ReverseIterator(IList<T> list)
            {
                _list = list;
                _nextIndex = _list.Size() - 1;
            }

            public bool HasNext()
            {
                return _nextIndex >= 0;
            }

            public T Next()
            {
                if (HasNext()) {
                    return _list.Get(_nextIndex--);
                }

                throw new NoSuchElementException();
            }
        }
    }
}
