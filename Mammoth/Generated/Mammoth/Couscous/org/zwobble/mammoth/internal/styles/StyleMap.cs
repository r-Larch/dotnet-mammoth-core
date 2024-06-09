using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap {
        internal static StyleMap _EMPTY;
        internal Optional<HtmlPath> _bold;
        internal List<StyleMapping<Break>> _breakStyles;
        internal Optional<HtmlPath> _commentReference;
        internal Optional<HtmlPath> _italic;
        internal List<StyleMapping<Paragraph>> _paragraphStyles;
        internal List<StyleMapping<Run>> _runStyles;
        internal Optional<HtmlPath> _smallCaps;
        internal Optional<HtmlPath> _strikethrough;
        internal List<StyleMapping<Table>> _tableStyles;
        internal Optional<HtmlPath> _underline;

        static StyleMap()
        {
            _EMPTY = (new StyleMapBuilder()).build();
        }

        internal StyleMap(Optional<HtmlPath> bold, Optional<HtmlPath> italic, Optional<HtmlPath> underline, Optional<HtmlPath> strikethrough, Optional<HtmlPath> smallCaps, Optional<HtmlPath> commentReference, List<StyleMapping<Paragraph>> paragraphStyles, List<StyleMapping<Run>> runStyles, List<StyleMapping<Table>> tableStyles, List<StyleMapping<Break>> breakStyles)
        {
            _bold = bold;
            _italic = italic;
            _underline = underline;
            _strikethrough = strikethrough;
            _smallCaps = smallCaps;
            _commentReference = commentReference;
            _paragraphStyles = paragraphStyles;
            _runStyles = runStyles;
            _tableStyles = tableStyles;
            _breakStyles = breakStyles;
        }

        public static StyleMapBuilder builder()
        {
            return new StyleMapBuilder();
        }

        public static StyleMap merge(StyleMap high, StyleMap low)
        {
            return new StyleMap(Optionals.first(high._bold, low._bold), Optionals.first(high._italic, low._italic), Optionals.first(high._underline, low._underline), Optionals.first(high._strikethrough, low._strikethrough), Optionals.first(high._smallCaps, low._smallCaps), Optionals.first(high._commentReference, low._commentReference), Lists.eagerConcat(high._paragraphStyles, low._paragraphStyles), Lists.eagerConcat(high._runStyles, low._runStyles), Lists.eagerConcat(high._tableStyles, low._tableStyles), Lists.eagerConcat(high._breakStyles, low._breakStyles));
        }

        public StyleMap update(StyleMap styleMap)
        {
            return merge(styleMap, this);
        }

        public Optional<HtmlPath> getBold()
        {
            return _bold;
        }

        public Optional<HtmlPath> getItalic()
        {
            return _italic;
        }

        public Optional<HtmlPath> getUnderline()
        {
            return _underline;
        }

        public Optional<HtmlPath> getStrikethrough()
        {
            return _strikethrough;
        }

        public Optional<HtmlPath> getSmallCaps()
        {
            return _smallCaps;
        }

        public Optional<HtmlPath> getCommentReference()
        {
            return _commentReference;
        }

        public Optional<HtmlPath> getParagraphHtmlPath(Paragraph paragraph)
        {
            return (Iterables.tryFind(_paragraphStyles, new StyleMap__Anonymous_0(paragraph))).map(new StyleMap__Anonymous_1());
        }

        public Optional<HtmlPath> getRunHtmlPath(Run run)
        {
            return (Iterables.tryFind(_runStyles, new StyleMap__Anonymous_2(run))).map(new StyleMap__Anonymous_3());
        }

        public Optional<HtmlPath> getTableHtmlPath(Table table)
        {
            return (Iterables.tryFind(_tableStyles, new StyleMap__Anonymous_4(table))).map(new StyleMap__Anonymous_5());
        }

        public Optional<HtmlPath> getBreakHtmlPath(Break breakElement)
        {
            return (Iterables.tryFind(_breakStyles, new StyleMap__Anonymous_6(breakElement))).map(new StyleMap__Anonymous_7());
        }
    }
}
