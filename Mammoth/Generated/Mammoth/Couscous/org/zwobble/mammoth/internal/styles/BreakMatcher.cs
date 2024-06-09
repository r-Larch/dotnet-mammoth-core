namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class BreakMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _LINE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _PAGE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _COLUMN_BREAK;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type _breakType;
        static BreakMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._LINE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._PAGE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._PAGE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._COLUMN_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._COLUMN);
        }
        internal BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type breakType) {
            this._breakType = breakType;
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break element) {
            return (element.getType()).equals(this._breakType);
        }
    }
}

