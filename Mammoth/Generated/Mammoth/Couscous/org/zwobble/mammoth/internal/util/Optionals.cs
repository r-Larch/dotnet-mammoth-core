namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class Optionals {
        public static Mammoth.Couscous.java.util.Optional<T> first<T>(Mammoth.Couscous.java.util.Optional<T> first, Mammoth.Couscous.java.util.Optional<T> second) {
            if (first.isPresent()) {
                return first;
            } else {
                return second;
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> flatMap<T1, T2, R>(Mammoth.Couscous.java.util.Optional<T1> first, Mammoth.Couscous.java.util.Optional<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, Mammoth.Couscous.java.util.Optional<R>> function) {
            if (first.isPresent() && second.isPresent()) {
                return function.apply(first.get(), second.get());
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> map<T1, T2, R>(Mammoth.Couscous.java.util.Optional<T1> first, Mammoth.Couscous.java.util.Optional<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, R> function) {
            if (first.isPresent() && second.isPresent()) {
                return Mammoth.Couscous.java.util.Optional.of<R>(function.apply(first.get(), second.get()));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> map<R>(Mammoth.Couscous.java.util.OptionalInt first, Mammoth.Couscous.java.util.function.IntFunction<R> function) {
            if (first.isPresent()) {
                return Mammoth.Couscous.java.util.Optional.of<R>(function.apply(first.getAsInt()));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
    }
}

