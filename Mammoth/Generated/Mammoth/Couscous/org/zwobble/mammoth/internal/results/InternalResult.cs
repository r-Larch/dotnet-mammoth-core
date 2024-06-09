using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult {
        public static InternalResult<IList<TR>> FlatMap<T, TR>(ITerable<T> iterable, IFunction<T, InternalResult<TR>> function)
        {
            var results = Lists.EagerMap(iterable, function);
            return new InternalResult<IList<TR>>(Lists.EagerMap(results, new InternalResultAnonymous0<TR>()), Iterables.LazyFlatMap(results, new InternalResultAnonymous1<TR>()));
        }

        public static InternalResult<TR> FlatMap<T1, T2, TR>(InternalResult<T1> first, InternalResult<T2> second, IBiFunction<T1, T2, InternalResult<TR>> function)
        {
            var intermediateResult = function.Apply(first.Value, second.Value);
            return new InternalResult<TR>(intermediateResult.Value, Iterables.LazyConcat(Iterables.LazyConcat(first.Warnings, second.Warnings), intermediateResult.Warnings));
        }

        public static InternalResult<TR> Map<T1, T2, TR>(InternalResult<T1> first, InternalResult<T2> second, IBiFunction<T1, T2, TR> function)
        {
            return new InternalResult<TR>(function.Apply(first.Value, second.Value), Iterables.LazyConcat(first.Warnings, second.Warnings));
        }

        public static InternalResult<IOptional<Style>> Empty()
        {
            return new InternalResult<IOptional<Style>>(Optional.Empty<Style>(), Lists.List<string>());
        }

        public static InternalResult<T> Success<T>(T value)
        {
            return new InternalResult<T>(value, Lists.List<string>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult<T> {
        public T Value;
        public ITerable<string> Warnings;

        internal InternalResult(T value, ITerable<string> warnings)
        {
            Value = value;
            Warnings = warnings;
        }

        public T GetValue()
        {
            return Value;
        }

        public ITerable<string> GetWarnings()
        {
            return Warnings;
        }

        public InternalResult<TR> Map<TR>(IFunction<T, TR> function)
        {
            return new InternalResult<TR>(function.Apply(Value), Warnings);
        }

        public InternalResult<TR> FlatMap<TR>(IFunction<T, InternalResult<TR>> function)
        {
            var intermediateResult = function.Apply(Value);
            return new InternalResult<TR>(intermediateResult.Value, Iterables.LazyConcat(Warnings, intermediateResult.Warnings));
        }

        public IResult<T> ToResult()
        {
            var warnings = Sets.ToSet(Warnings);
            return new InternalResultAnonymous2<T>(this, warnings);
        }
    }
}
