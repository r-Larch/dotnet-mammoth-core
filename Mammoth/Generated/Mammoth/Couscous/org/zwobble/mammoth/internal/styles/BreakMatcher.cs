using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class BreakMatcher : DocumentElementMatcher<Break> {
        internal static BreakMatcher _LINE_BREAK;
        internal static BreakMatcher _PAGE_BREAK;
        internal static BreakMatcher _COLUMN_BREAK;
        internal Break__Type _breakType;

        static BreakMatcher()
        {
            _LINE_BREAK = new BreakMatcher(Break__Type._LINE);
            _PAGE_BREAK = new BreakMatcher(Break__Type._PAGE);
            _COLUMN_BREAK = new BreakMatcher(Break__Type._COLUMN);
        }

        internal BreakMatcher(Break__Type breakType)
        {
            _breakType = breakType;
        }

        public bool matches(Break element)
        {
            return (element.getType()).equals(_breakType);
        }
    }
}
