using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class TableMatcher : IDocumentElementMatcher<Table> {
        public static TableMatcher Any;
        private IOptional<string> _styleId;
        private IOptional<IStringMatcher> _styleName;

        static TableMatcher()
        {
            Any = new TableMatcher(Optional.Empty<string>(), Optional.Empty<IStringMatcher>());
        }

        internal TableMatcher(IOptional<string> styleId, IOptional<IStringMatcher> styleName)
        {
            _styleId = styleId;
            _styleName = styleName;
        }

        public bool Matches(Table table)
        {
            return DocumentElementMatching.MatchesStyle(_styleId, _styleName, table.GetStyle());
        }

        public static TableMatcher StyleId(string styleId)
        {
            return new TableMatcher(Optional.Of(styleId), Optional.Empty<IStringMatcher>());
        }

        public static TableMatcher StyleName(string styleName)
        {
            return new TableMatcher(Optional.Empty<string>(), Optional.Of<IStringMatcher>(new EqualToStringMatcher(styleName)));
        }
    }
}
