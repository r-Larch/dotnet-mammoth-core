using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResultAnonymous2 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResultAnonymous2<T> : IResult<T> {
        private InternalResult<T> _thisOrgZwobbleMammothInternalResultsInternalResult;
        private ISet<string> _warnings;

        internal InternalResultAnonymous2(InternalResult<T> thisOrgZwobbleMammothInternalResultsInternalResult, ISet<string> warnings)
        {
            _thisOrgZwobbleMammothInternalResultsInternalResult = thisOrgZwobbleMammothInternalResultsInternalResult;
            _warnings = warnings;
        }

        public T GetValue()
        {
            return (_thisOrgZwobbleMammothInternalResultsInternalResult).Value;
        }

        public ISet<string> GetWarnings()
        {
            return _warnings;
        }
    }
}
