using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_1 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_1<R> : Function<InternalResult<R>, Iterable<string>> {
        public Iterable<string> apply(InternalResult<R> result)
        {
            return result._warnings;
        }
    }
}
