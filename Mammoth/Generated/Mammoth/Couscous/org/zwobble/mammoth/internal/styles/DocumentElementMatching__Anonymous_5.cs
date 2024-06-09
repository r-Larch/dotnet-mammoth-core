using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_5 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_5<T, U> : Function<T, bool> {
        internal Optional<U> _actual;
        internal BiPredicate<T, U> _areEqual;

        internal DocumentElementMatching__Anonymous_5(Optional<U> actual, BiPredicate<T, U> areEqual)
        {
            _actual = actual;
            _areEqual = areEqual;
        }

        public bool apply(T requiredValue)
        {
            return ((_actual).map(new DocumentElementMatching__Anonymous_4<U, T>(_areEqual, requiredValue))).orElse(false);
        }
    }
}
