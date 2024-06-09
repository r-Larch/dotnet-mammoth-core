using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class TableMatcher(IOptional<string> styleId, IOptional<IStringMatcher> styleName) : IDocumentElementMatcher<Table> {
        public static TableMatcher Any = new(Optional.Empty<string>(), Optional.Empty<IStringMatcher>());

        public bool Matches(Table table)
        {
            return DocumentElementMatching.MatchesStyle(styleId, styleName, table.GetStyle());
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
