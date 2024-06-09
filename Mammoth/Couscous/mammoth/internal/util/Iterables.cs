using System;
using System.Linq;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Iterables {
        internal static IOptional<T> GetFirst<T>(ITerable<T> iterable)
        {
            var iterator = iterable.Iterator();
            if (iterator.HasNext()) {
                return Optional.Of(iterator.Next());
            }

            return Optional.Empty<T>();
        }

        internal static T GetFirst<T>(ITerable<T> iterable, T defaultValue)
        {
            var iterator = iterable.Iterator();
            if (iterator.HasNext()) {
                return iterator.Next();
            }

            return defaultValue;
        }

        internal static IOptional<T> TryGetLast<T>(ITerable<T> iterable) where T : class
        {
            var hasElement = false;
            T last = null;
            var iterator = iterable.Iterator();
            while (iterator.HasNext()) {
                hasElement = true;
                last = iterator.Next();
            }

            if (hasElement) {
                return Optional.Of(last);
            }

            return Optional.Empty<T>();
        }

        internal static IOptional<T> TryFind<T>(ITerable<T> iterable, java.util.function.IPredicate<T> predicate)
        {
            var iterator = iterable.Iterator();
            while (iterator.HasNext()) {
                var value = iterator.Next();
                if (predicate.Test(value)) {
                    return new Some<T>(value);
                }
            }

            return None<T>.Instance;
        }

        internal static IOptionalInt FindIndex<T>(ITerable<T> iterable, java.util.function.IPredicate<T> predicate)
        {
            var iterator = iterable.Iterator();
            var index = 0;
            while (iterator.HasNext()) {
                var value = iterator.Next();
                if (predicate.Test(value)) {
                    return new SomeInt(index);
                }

                index++;
            }

            return NoneInt.Instance;
        }

        internal static ITerable<T> LazyFilter<T>(ITerable<T> iterable, java.util.function.IPredicate<T> predicate)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable).Where(predicate.Test);
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static ITerable<TU> LazyFilter<T, TU>(ITerable<T> iterable, Type type)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable).OfType<TU>();
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static ITerable<TU> LazyMap<T, TU>(ITerable<T> iterable, IFunction<T, TU> function)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable)
                .Select(function.Apply);
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static ITerable<TU> LazyFlatMap<T, TU>(ITerable<T> iterable, IFunction<T, ITerable<TU>> function)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable)
                .SelectMany(element => FromJava.IterableToEnumerable(function.Apply(element)));
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static ITerable<T> LazyConcat<T>(ITerable<T> first, ITerable<T> second)
        {
            var enumerable = FromJava.IterableToEnumerable(first)
                .Concat(FromJava.IterableToEnumerable(second));
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static ITerable<int> IntRange(int start, int end)
        {
            return new IntRangeGenerator(start, end);
        }

        private class IntRangeGenerator : ITerable<int> {
            private readonly int _end;
            private readonly int _start;

            internal IntRangeGenerator(int start, int end)
            {
                _start = start;
                _end = end;
            }

            public ITerator<int> Iterator()
            {
                return new IntRangeIterator(_start, _end);
            }
        }

        private class IntRangeIterator : ITerator<int> {
            private readonly int _end;
            private int _next;

            internal IntRangeIterator(int start, int end)
            {
                _next = start;
                _end = end;
            }

            public bool HasNext()
            {
                return _next < _end;
            }

            public int Next()
            {
                return _next++;
            }
        }
    }
}
