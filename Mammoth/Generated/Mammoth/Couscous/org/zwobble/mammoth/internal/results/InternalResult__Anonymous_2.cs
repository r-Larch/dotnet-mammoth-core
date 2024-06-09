namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_2 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_2<T> : Mammoth.Couscous.org.zwobble.mammoth.Result<T> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> _this_org__zwobble__mammoth__internal__results__InternalResult;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal InternalResult__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> this_org__zwobble__mammoth__internal__results__InternalResult, Mammoth.Couscous.java.util.Set<string> warnings) {
            this._this_org__zwobble__mammoth__internal__results__InternalResult = this_org__zwobble__mammoth__internal__results__InternalResult;
            this._warnings = warnings;
        }
        public T getValue() {
            return (this._this_org__zwobble__mammoth__internal__results__InternalResult)._value;
        }
        public Mammoth.Couscous.java.util.Set<string> getWarnings() {
            return this._warnings;
        }
    }
}

