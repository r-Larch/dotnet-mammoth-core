using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class Optionals {
        public static Optional<T> first<T>(Optional<T> first, Optional<T> second)
        {
            if (first.isPresent()) {
                return first;
            }

            return second;
        }

        public static Optional<R> flatMap<T1, T2, R>(Optional<T1> first, Optional<T2> second, BiFunction<T1, T2, Optional<R>> function)
        {
            if (first.isPresent() && second.isPresent()) {
                return function.apply(first.get(), second.get());
            }

            return Optional.empty<R>();
        }

        public static Optional<R> map<T1, T2, R>(Optional<T1> first, Optional<T2> second, BiFunction<T1, T2, R> function)
        {
            if (first.isPresent() && second.isPresent()) {
                return Optional.of(function.apply(first.get(), second.get()));
            }

            return Optional.empty<R>();
        }

        public static Optional<R> map<R>(OptionalInt first, IntFunction<R> function)
        {
            if (first.isPresent()) {
                return Optional.of(function.apply(first.getAsInt()));
            }

            return Optional.empty<R>();
        }
    }
}
