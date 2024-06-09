using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult {
        public static InternalResult<List<R>> flatMap<T, R>(Iterable<T> iterable, Function<T, InternalResult<R>> function)
        {
            var results = Lists.eagerMap(iterable, function);
            return new InternalResult<List<R>>(Lists.eagerMap(results, new InternalResult__Anonymous_0<R>()), Iterables.lazyFlatMap(results, new InternalResult__Anonymous_1<R>()));
        }

        public static InternalResult<R> flatMap<T1, T2, R>(InternalResult<T1> first, InternalResult<T2> second, BiFunction<T1, T2, InternalResult<R>> function)
        {
            var intermediateResult = function.apply(first._value, second._value);
            return new InternalResult<R>(intermediateResult._value, Iterables.lazyConcat(Iterables.lazyConcat(first._warnings, second._warnings), intermediateResult._warnings));
        }

        public static InternalResult<R> map<T1, T2, R>(InternalResult<T1> first, InternalResult<T2> second, BiFunction<T1, T2, R> function)
        {
            return new InternalResult<R>(function.apply(first._value, second._value), Iterables.lazyConcat(first._warnings, second._warnings));
        }

        public static InternalResult<Optional<Style>> empty()
        {
            return new InternalResult<Optional<Style>>(Optional.empty<Style>(), Lists.list<string>());
        }

        public static InternalResult<T> success<T>(T value)
        {
            return new InternalResult<T>(value, Lists.list<string>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult<T> {
        public T _value;
        public Iterable<string> _warnings;

        internal InternalResult(T value, Iterable<string> warnings)
        {
            _value = value;
            _warnings = warnings;
        }

        public T getValue()
        {
            return _value;
        }

        public Iterable<string> getWarnings()
        {
            return _warnings;
        }

        public InternalResult<R> map<R>(Function<T, R> function)
        {
            return new InternalResult<R>(function.apply(_value), _warnings);
        }

        public InternalResult<R> flatMap<R>(Function<T, InternalResult<R>> function)
        {
            var intermediateResult = function.apply(_value);
            return new InternalResult<R>(intermediateResult._value, Iterables.lazyConcat(_warnings, intermediateResult._warnings));
        }

        public Result<T> toResult()
        {
            var warnings = Sets.toSet(_warnings);
            return new InternalResult__Anonymous_2<T>(this, warnings);
        }
    }
}
