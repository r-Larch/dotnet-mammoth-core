namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_4 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_4<U, T> : Mammoth.Couscous.java.util.function.Function<U, bool> {
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, U> _areEqual;
        internal T _requiredValue;
        internal DocumentElementMatching__Anonymous_4(Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual, T requiredValue) {
            this._areEqual = areEqual;
            this._requiredValue = requiredValue;
        }
        public bool apply(U actualValue) {
            return (this._areEqual).test(this._requiredValue, actualValue);
        }
    }
}

