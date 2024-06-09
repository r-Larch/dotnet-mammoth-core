using System;
using System.Linq;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Iterables {
        internal static Optional<T> getFirst<T>(Iterable<T> iterable)
        {
            var iterator = iterable.iterator();
            if (iterator.hasNext()) {
                return Optional.of(iterator.next());
            }

            return Optional.empty<T>();
        }

        internal static T getFirst<T>(Iterable<T> iterable, T defaultValue)
        {
            var iterator = iterable.iterator();
            if (iterator.hasNext()) {
                return iterator.next();
            }

            return defaultValue;
        }

        internal static Optional<T> tryGetLast<T>(Iterable<T> iterable) where T : class
        {
            var hasElement = false;
            T last = null;
            var iterator = iterable.iterator();
            while (iterator.hasNext()) {
                hasElement = true;
                last = iterator.next();
            }

            if (hasElement) {
                return Optional.of(last);
            }

            return Optional.empty<T>();
        }

        internal static Optional<T> tryFind<T>(Iterable<T> iterable, java.util.function.Predicate<T> predicate)
        {
            var iterator = iterable.iterator();
            while (iterator.hasNext()) {
                var value = iterator.next();
                if (predicate.test(value)) {
                    return new Some<T>(value);
                }
            }

            return None<T>.Instance;
        }

        internal static OptionalInt findIndex<T>(Iterable<T> iterable, java.util.function.Predicate<T> predicate)
        {
            var iterator = iterable.iterator();
            var index = 0;
            while (iterator.hasNext()) {
                var value = iterator.next();
                if (predicate.test(value)) {
                    return new SomeInt(index);
                }

                index++;
            }

            return NoneInt.Instance;
        }

        internal static Iterable<T> lazyFilter<T>(Iterable<T> iterable, java.util.function.Predicate<T> predicate)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable).Where(predicate.test);
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static Iterable<U> lazyFilter<T, U>(Iterable<T> iterable, Type type)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable).OfType<U>();
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static Iterable<U> lazyMap<T, U>(Iterable<T> iterable, Function<T, U> function)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable)
                .Select(function.apply);
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static Iterable<U> lazyFlatMap<T, U>(Iterable<T> iterable, Function<T, Iterable<U>> function)
        {
            var enumerable = FromJava.IterableToEnumerable(iterable)
                .SelectMany(element => FromJava.IterableToEnumerable(function.apply(element)));
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static Iterable<T> lazyConcat<T>(Iterable<T> first, Iterable<T> second)
        {
            var enumerable = FromJava.IterableToEnumerable(first)
                .Concat(FromJava.IterableToEnumerable(second));
            return ToJava.EnumerableToIterable(enumerable);
        }

        internal static Iterable<int> intRange(int start, int end)
        {
            return new IntRange(start, end);
        }

        private class IntRange : Iterable<int> {
            private readonly int _end;
            private readonly int _start;

            internal IntRange(int start, int end)
            {
                _start = start;
                _end = end;
            }

            public Iterator<int> iterator()
            {
                return new IntRangeIterator(_start, _end);
            }
        }

        private class IntRangeIterator : Iterator<int> {
            private readonly int _end;
            private int _next;

            internal IntRangeIterator(int start, int end)
            {
                _next = start;
                _end = end;
            }

            public bool hasNext()
            {
                return _next < _end;
            }

            public int next()
            {
                return _next++;
            }
        }
    }
}
