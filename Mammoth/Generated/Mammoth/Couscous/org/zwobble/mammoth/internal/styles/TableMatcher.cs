using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class TableMatcher : DocumentElementMatcher<Table> {
        internal static TableMatcher _ANY;
        internal Optional<string> _styleId;
        internal Optional<StringMatcher> _styleName;

        static TableMatcher()
        {
            _ANY = new TableMatcher(Optional.empty<string>(), Optional.empty<StringMatcher>());
        }

        internal TableMatcher(Optional<string> styleId, Optional<StringMatcher> styleName)
        {
            _styleId = styleId;
            _styleName = styleName;
        }

        public bool matches(Table table)
        {
            return DocumentElementMatching.matchesStyle(_styleId, _styleName, table.getStyle());
        }

        public static TableMatcher styleId(string styleId)
        {
            return new TableMatcher(Optional.of(styleId), Optional.empty<StringMatcher>());
        }

        public static TableMatcher styleName(string styleName)
        {
            return new TableMatcher(Optional.empty<string>(), Optional.of<StringMatcher>(new EqualToStringMatcher(styleName)));
        }
    }
}
