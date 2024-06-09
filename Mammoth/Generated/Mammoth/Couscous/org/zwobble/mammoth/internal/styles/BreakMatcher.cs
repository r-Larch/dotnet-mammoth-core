using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class BreakMatcher : IDocumentElementMatcher<Break> {
        public static BreakMatcher LineBreak;
        public static BreakMatcher PageBreak;
        public static BreakMatcher ColumnBreak;
        private BreakType _breakType;

        static BreakMatcher()
        {
            LineBreak = new BreakMatcher(BreakType.Line);
            PageBreak = new BreakMatcher(BreakType.Page);
            ColumnBreak = new BreakMatcher(BreakType.Column);
        }

        internal BreakMatcher(BreakType breakType)
        {
            _breakType = breakType;
        }

        public bool Matches(Break element)
        {
            return (element.Type) == (_breakType);
        }
    }
}
