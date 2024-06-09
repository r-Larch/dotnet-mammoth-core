using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResultAnonymous0<TR> : IFunction<InternalResult<TR>, TR> {
        public TR Apply(InternalResult<TR> result)
        {
            return result.Value;
        }
    }

    internal class InternalResultAnonymous1<TR> : IFunction<InternalResult<TR>, ITerable<string>> {
        public ITerable<string> Apply(InternalResult<TR> result)
        {
            return result.Warnings;
        }
    }

    internal class InternalResultAnonymous2<T> : IResult<T> {
        private readonly InternalResult<T> _thisOrgZwobbleMammothInternalResultsInternalResult;
        private readonly ISet<string> _warnings;

        internal InternalResultAnonymous2(InternalResult<T> thisOrgZwobbleMammothInternalResultsInternalResult, ISet<string> warnings)
        {
            _thisOrgZwobbleMammothInternalResultsInternalResult = thisOrgZwobbleMammothInternalResultsInternalResult;
            _warnings = warnings;
        }

        public T GetValue()
        {
            return _thisOrgZwobbleMammothInternalResultsInternalResult.Value;
        }

        public ISet<string> GetWarnings()
        {
            return _warnings;
        }
    }
}
