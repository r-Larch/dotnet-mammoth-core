using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcherAnonymous0 : IBiPredicate<NumberingLevel, NumberingLevel> {
        public bool Test(NumberingLevel first, NumberingLevel second)
        {
            return first.IsOrdered() == second.IsOrdered() && first.GetLevelIndex().EqualsIgnoreCase(second.GetLevelIndex());
        }
    }
}
