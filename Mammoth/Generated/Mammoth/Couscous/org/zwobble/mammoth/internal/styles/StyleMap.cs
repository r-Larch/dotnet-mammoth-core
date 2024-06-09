using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap {
        public static StyleMap Empty;
        private IOptional<IHtmlPath> _bold;
        private IList<StyleMapping<Break>> _breakStyles;
        private IOptional<IHtmlPath> _commentReference;
        private IOptional<IHtmlPath> _italic;
        private IList<StyleMapping<Paragraph>> _paragraphStyles;
        private IList<StyleMapping<Run>> _runStyles;
        private IOptional<IHtmlPath> _smallCaps;
        private IOptional<IHtmlPath> _strikethrough;
        private IList<StyleMapping<Table>> _tableStyles;
        private IOptional<IHtmlPath> _underline;

        static StyleMap()
        {
            Empty = (new StyleMapBuilder()).Build();
        }

        internal StyleMap(IOptional<IHtmlPath> bold, IOptional<IHtmlPath> italic, IOptional<IHtmlPath> underline, IOptional<IHtmlPath> strikethrough, IOptional<IHtmlPath> smallCaps, IOptional<IHtmlPath> commentReference, IList<StyleMapping<Paragraph>> paragraphStyles, IList<StyleMapping<Run>> runStyles, IList<StyleMapping<Table>> tableStyles, IList<StyleMapping<Break>> breakStyles)
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

        public static StyleMapBuilder Builder()
        {
            return new StyleMapBuilder();
        }

        public static StyleMap Merge(StyleMap high, StyleMap low)
        {
            return new StyleMap(Optionals.First(high._bold, low._bold), Optionals.First(high._italic, low._italic), Optionals.First(high._underline, low._underline), Optionals.First(high._strikethrough, low._strikethrough), Optionals.First(high._smallCaps, low._smallCaps), Optionals.First(high._commentReference, low._commentReference), Lists.EagerConcat(high._paragraphStyles, low._paragraphStyles), Lists.EagerConcat(high._runStyles, low._runStyles), Lists.EagerConcat(high._tableStyles, low._tableStyles), Lists.EagerConcat(high._breakStyles, low._breakStyles));
        }

        public StyleMap Update(StyleMap styleMap)
        {
            return Merge(styleMap, this);
        }

        public IOptional<IHtmlPath> GetBold()
        {
            return _bold;
        }

        public IOptional<IHtmlPath> GetItalic()
        {
            return _italic;
        }

        public IOptional<IHtmlPath> GetUnderline()
        {
            return _underline;
        }

        public IOptional<IHtmlPath> GetStrikethrough()
        {
            return _strikethrough;
        }

        public IOptional<IHtmlPath> GetSmallCaps()
        {
            return _smallCaps;
        }

        public IOptional<IHtmlPath> GetCommentReference()
        {
            return _commentReference;
        }

        public IOptional<IHtmlPath> GetParagraphHtmlPath(Paragraph paragraph)
        {
            return (Iterables.TryFind(_paragraphStyles, new StyleMapAnonymous0(paragraph))).Map(new StyleMapAnonymous1());
        }

        public IOptional<IHtmlPath> GetRunHtmlPath(Run run)
        {
            return (Iterables.TryFind(_runStyles, new StyleMapAnonymous2(run))).Map(new StyleMapAnonymous3());
        }

        public IOptional<IHtmlPath> GetTableHtmlPath(Table table)
        {
            return (Iterables.TryFind(_tableStyles, new StyleMapAnonymous4(table))).Map(new StyleMapAnonymous5());
        }

        public IOptional<IHtmlPath> GetBreakHtmlPath(Break breakElement)
        {
            return (Iterables.TryFind(_breakStyles, new StyleMapAnonymous6(breakElement))).Map(new StyleMapAnonymous7());
        }
    }
}
