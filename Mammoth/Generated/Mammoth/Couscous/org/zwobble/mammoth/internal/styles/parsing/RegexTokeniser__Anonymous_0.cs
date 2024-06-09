using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__Anonymous_0 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_0<T> : Function<RegexTokeniser__TokenRule<T>, string> {
        public string apply(RegexTokeniser__TokenRule<T> rule)
        {
            return ("(" + (rule._regex).pattern()) + ")";
        }
    }
}
