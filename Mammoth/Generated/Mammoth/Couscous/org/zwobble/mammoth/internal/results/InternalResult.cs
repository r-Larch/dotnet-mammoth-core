namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>> flatMap<T, R>(Mammoth.Couscous.java.lang.Iterable<T> iterable, Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> results = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>>(iterable, function);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, R>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_0<R>()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_1<R>()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> flatMap<T1, T2, R>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T1> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> intermediateResult = function.apply(first._value, second._value);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(intermediateResult._value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first._warnings, second._warnings), intermediateResult._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> map<T1, T2, R>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T1> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, R> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(function.apply(first._value, second._value), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first._warnings, second._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> empty() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> success<T>(T value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T>(value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult<T> {
        internal T _value;
        internal Mammoth.Couscous.java.lang.Iterable<string> _warnings;
        internal InternalResult(T value, Mammoth.Couscous.java.lang.Iterable<string> warnings) {
            this._value = value;
            this._warnings = warnings;
        }
        public T getValue() {
            return this._value;
        }
        public Mammoth.Couscous.java.lang.Iterable<string> getWarnings() {
            return this._warnings;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> map<R>(Mammoth.Couscous.java.util.function.Function<T, R> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(function.apply(this._value), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> flatMap<R>(Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> intermediateResult = function.apply(this._value);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(intermediateResult._value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(this._warnings, intermediateResult._warnings));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.Result<T> toResult() {
            Mammoth.Couscous.java.util.Set<string> warnings = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.toSet<string>(this._warnings);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_2<T>(this, warnings);
        }
    }
}

