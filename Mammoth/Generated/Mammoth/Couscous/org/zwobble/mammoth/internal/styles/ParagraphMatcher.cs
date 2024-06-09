using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher : IDocumentElementMatcher<Paragraph> {
        public static ParagraphMatcher Any;
        private IOptional<NumberingLevel> _numbering;
        private IOptional<string> _styleId;
        private IOptional<IStringMatcher> _styleName;

        static ParagraphMatcher()
        {
            Any = new ParagraphMatcher(Optional.Empty<string>(), Optional.Empty<IStringMatcher>(), Optional.Empty<NumberingLevel>());
        }

        internal ParagraphMatcher(IOptional<string> styleId, IOptional<IStringMatcher> styleName, IOptional<NumberingLevel> numbering)
        {
            _styleId = styleId;
            _styleName = styleName;
            _numbering = numbering;
        }

        public bool Matches(Paragraph paragraph)
        {
            return MatchesStyle(paragraph) && MatchesNumbering(paragraph);
        }

        public static ParagraphMatcher StyleId(string styleId)
        {
            return new ParagraphMatcher(Optional.Of(styleId), Optional.Empty<IStringMatcher>(), Optional.Empty<NumberingLevel>());
        }

        public static ParagraphMatcher StyleName(string styleName)
        {
            return ParagraphMatcher.StyleName(new EqualToStringMatcher(styleName));
        }

        public static ParagraphMatcher StyleName(IStringMatcher styleName)
        {
            return new ParagraphMatcher(Optional.Empty<string>(), Optional.Of(styleName), Optional.Empty<NumberingLevel>());
        }

        public static ParagraphMatcher OrderedList(string level)
        {
            return new ParagraphMatcher(Optional.Empty<string>(), Optional.Empty<IStringMatcher>(), Optional.Of(NumberingLevel.Ordered(level)));
        }

        public static ParagraphMatcher UnorderedList(string level)
        {
            return new ParagraphMatcher(Optional.Empty<string>(), Optional.Empty<IStringMatcher>(), Optional.Of(NumberingLevel.Unordered(level)));
        }

        public bool MatchesStyle(Paragraph paragraph)
        {
            return DocumentElementMatching.MatchesStyle(_styleId, _styleName, paragraph.GetStyle());
        }

        public bool MatchesNumbering(Paragraph paragraph)
        {
            return DocumentElementMatching.Matches(_numbering, paragraph.GetNumbering(), new ParagraphMatcherAnonymous0());
        }
    }
}
