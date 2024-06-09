namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher__Anonymous_0 : Mammoth.Couscous.java.util.function.BiPredicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> {
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel first, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel second) {
            return first.isOrdered() == second.isOrdered() && (first.getLevelIndex()).equalsIgnoreCase(second.getLevelIndex());
        }
    }
}

