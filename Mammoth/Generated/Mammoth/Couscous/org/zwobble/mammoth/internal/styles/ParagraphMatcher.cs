using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher : DocumentElementMatcher<Paragraph> {
        internal static ParagraphMatcher _ANY;
        internal Optional<NumberingLevel> _numbering;
        internal Optional<string> _styleId;
        internal Optional<StringMatcher> _styleName;

        static ParagraphMatcher()
        {
            _ANY = new ParagraphMatcher(Optional.empty<string>(), Optional.empty<StringMatcher>(), Optional.empty<NumberingLevel>());
        }

        internal ParagraphMatcher(Optional<string> styleId, Optional<StringMatcher> styleName, Optional<NumberingLevel> numbering)
        {
            _styleId = styleId;
            _styleName = styleName;
            _numbering = numbering;
        }

        public bool matches(Paragraph paragraph)
        {
            return matchesStyle(paragraph) && matchesNumbering(paragraph);
        }

        public static ParagraphMatcher styleId(string styleId)
        {
            return new ParagraphMatcher(Optional.of(styleId), Optional.empty<StringMatcher>(), Optional.empty<NumberingLevel>());
        }

        public static ParagraphMatcher styleName(string styleName)
        {
            return ParagraphMatcher.styleName(new EqualToStringMatcher(styleName));
        }

        public static ParagraphMatcher styleName(StringMatcher styleName)
        {
            return new ParagraphMatcher(Optional.empty<string>(), Optional.of(styleName), Optional.empty<NumberingLevel>());
        }

        public static ParagraphMatcher orderedList(string level)
        {
            return new ParagraphMatcher(Optional.empty<string>(), Optional.empty<StringMatcher>(), Optional.of(NumberingLevel.ordered(level)));
        }

        public static ParagraphMatcher unorderedList(string level)
        {
            return new ParagraphMatcher(Optional.empty<string>(), Optional.empty<StringMatcher>(), Optional.of(NumberingLevel.unordered(level)));
        }

        public bool matchesStyle(Paragraph paragraph)
        {
            return DocumentElementMatching.matchesStyle(_styleId, _styleName, paragraph.getStyle());
        }

        public bool matchesNumbering(Paragraph paragraph)
        {
            return DocumentElementMatching.matches(_numbering, paragraph.getNumbering(), new ParagraphMatcher__Anonymous_0());
        }
    }
}
