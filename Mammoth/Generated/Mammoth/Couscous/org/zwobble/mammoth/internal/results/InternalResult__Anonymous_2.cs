using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_2 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_2<T> : Result<T> {
        private InternalResult<T> _this_org__zwobble__mammoth__internal__results__InternalResult;
        private Set<string> _warnings;

        internal InternalResult__Anonymous_2(InternalResult<T> this_org__zwobble__mammoth__internal__results__InternalResult, Set<string> warnings)
        {
            _this_org__zwobble__mammoth__internal__results__InternalResult = this_org__zwobble__mammoth__internal__results__InternalResult;
            _warnings = warnings;
        }

        public T getValue()
        {
            return (_this_org__zwobble__mammoth__internal__results__InternalResult)._value;
        }

        public Set<string> getWarnings()
        {
            return _warnings;
        }
    }
}
