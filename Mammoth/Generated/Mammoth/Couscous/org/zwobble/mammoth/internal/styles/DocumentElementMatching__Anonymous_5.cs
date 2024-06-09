using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatchingAnonymous5 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatchingAnonymous5<T, TU> : IFunction<T, bool> {
        private IOptional<TU> _actual;
        private IBiPredicate<T, TU> _areEqual;

        internal DocumentElementMatchingAnonymous5(IOptional<TU> actual, IBiPredicate<T, TU> areEqual)
        {
            _actual = actual;
            _areEqual = areEqual;
        }

        public bool Apply(T requiredValue)
        {
            return ((_actual).Map(new DocumentElementMatchingAnonymous4<TU, T>(_areEqual, requiredValue))).OrElse(false);
        }
    }
}
