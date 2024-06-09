using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResultAnonymous1 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResultAnonymous1<TR> : IFunction<InternalResult<TR>, ITerable<string>> {
        public ITerable<string> Apply(InternalResult<TR> result)
        {
            return result.Warnings;
        }
    }
}
