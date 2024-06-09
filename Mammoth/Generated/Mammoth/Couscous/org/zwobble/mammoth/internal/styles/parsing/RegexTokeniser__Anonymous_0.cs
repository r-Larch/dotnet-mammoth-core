using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniserAnonymous0 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniserAnonymous0<T> : IFunction<RegexTokeniserTokenRule<T>, string> {
        public string Apply(RegexTokeniserTokenRule<T> rule)
        {
            return ("(" + (rule.Regex).Value) + ")";
        }
    }
}
