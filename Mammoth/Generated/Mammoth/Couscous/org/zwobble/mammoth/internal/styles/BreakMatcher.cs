using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class BreakMatcher : IDocumentElementMatcher<Break> {
        public static BreakMatcher LineBreak = new(BreakType.Line);
        public static BreakMatcher PageBreak = new(BreakType.Page);
        public static BreakMatcher ColumnBreak = new(BreakType.Column);
        private readonly BreakType _breakType;

        internal BreakMatcher(BreakType breakType)
        {
            _breakType = breakType;
        }

        public bool Matches(Break element)
        {
            return element.Type == _breakType;
        }
    }
}
