using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher__Anonymous_0 : BiPredicate<NumberingLevel, NumberingLevel> {
        public bool test(NumberingLevel first, NumberingLevel second)
        {
            return first.isOrdered() == second.isOrdered() && (first.getLevelIndex()).equalsIgnoreCase(second.getLevelIndex());
        }
    }
}
