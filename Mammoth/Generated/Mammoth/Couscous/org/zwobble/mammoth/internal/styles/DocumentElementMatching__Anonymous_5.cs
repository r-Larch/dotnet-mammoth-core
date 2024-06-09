namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_5 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_5<T, U> : Mammoth.Couscous.java.util.function.Function<T, bool> {
        internal Mammoth.Couscous.java.util.Optional<U> _actual;
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, U> _areEqual;
        internal DocumentElementMatching__Anonymous_5(Mammoth.Couscous.java.util.Optional<U> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual) {
            this._actual = actual;
            this._areEqual = areEqual;
        }
        public bool apply(T requiredValue) {
            return ((this._actual).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_4<U, T>(this._areEqual, requiredValue))).orElse(false);
        }
    }
}

