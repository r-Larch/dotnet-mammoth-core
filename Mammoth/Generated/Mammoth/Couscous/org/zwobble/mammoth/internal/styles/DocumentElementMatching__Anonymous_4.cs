using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_4 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_4<U, T> : Function<U, bool> {
        internal BiPredicate<T, U> _areEqual;
        internal T _requiredValue;

        internal DocumentElementMatching__Anonymous_4(BiPredicate<T, U> areEqual, T requiredValue)
        {
            _areEqual = areEqual;
            _requiredValue = requiredValue;
        }

        public bool apply(U actualValue)
        {
            return (_areEqual).test(_requiredValue, actualValue);
        }
    }
}
