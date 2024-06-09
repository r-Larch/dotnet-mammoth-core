using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatchingAnonymous4 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatchingAnonymous4<TU, T> : IFunction<TU, bool> {
        private IBiPredicate<T, TU> _areEqual;
        private T _requiredValue;

        internal DocumentElementMatchingAnonymous4(IBiPredicate<T, TU> areEqual, T requiredValue)
        {
            _areEqual = areEqual;
            _requiredValue = requiredValue;
        }

        public bool Apply(TU actualValue)
        {
            return (_areEqual).Test(_requiredValue, actualValue);
        }
    }
}
