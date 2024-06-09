using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class Optionals {
        public static IOptional<T> First<T>(IOptional<T> first, IOptional<T> second)
        {
            if (first.IsPresent()) {
                return first;
            }

            return second;
        }

        public static IOptional<TR> FlatMap<T1, T2, TR>(IOptional<T1> first, IOptional<T2> second, IBiFunction<T1, T2, IOptional<TR>> function)
        {
            if (first.IsPresent() && second.IsPresent()) {
                return function.Apply(first.Get(), second.Get());
            }

            return Optional.Empty<TR>();
        }

        public static IOptional<TR> Map<T1, T2, TR>(IOptional<T1> first, IOptional<T2> second, IBiFunction<T1, T2, TR> function)
        {
            if (first.IsPresent() && second.IsPresent()) {
                return Optional.Of(function.Apply(first.Get(), second.Get()));
            }

            return Optional.Empty<TR>();
        }

        public static IOptional<TR> Map<TR>(IOptionalInt first, INtFunction<TR> function)
        {
            if (first.IsPresent()) {
                return Optional.Of(function.Apply(first.GetAsInt()));
            }

            return Optional.Empty<TR>();
        }
    }
}
