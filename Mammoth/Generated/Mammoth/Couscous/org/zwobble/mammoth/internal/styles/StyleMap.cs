using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap(
        IOptional<IHtmlPath> bold,
        IOptional<IHtmlPath> italic,
        IOptional<IHtmlPath> underline,
        IOptional<IHtmlPath> strikethrough,
        IOptional<IHtmlPath> smallCaps,
        IOptional<IHtmlPath> commentReference,
        IList<StyleMapping<Paragraph>> paragraphStyles,
        IList<StyleMapping<Run>> runStyles,
        IList<StyleMapping<Table>> tableStyles,
        IList<StyleMapping<Break>> breakStyles
    ) {
        public static StyleMap Empty = new StyleMapBuilder().Build();
        private readonly IOptional<IHtmlPath> _bold = bold;
        private readonly IList<StyleMapping<Break>> _breakStyles = breakStyles;
        private readonly IOptional<IHtmlPath> _commentReference = commentReference;
        private readonly IOptional<IHtmlPath> _italic = italic;
        private readonly IList<StyleMapping<Paragraph>> _paragraphStyles = paragraphStyles;
        private readonly IList<StyleMapping<Run>> _runStyles = runStyles;
        private readonly IOptional<IHtmlPath> _smallCaps = smallCaps;
        private readonly IOptional<IHtmlPath> _strikethrough = strikethrough;
        private readonly IList<StyleMapping<Table>> _tableStyles = tableStyles;
        private readonly IOptional<IHtmlPath> _underline = underline;


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
            return Iterables.TryFind(_paragraphStyles, new StyleMapAnonymous0(paragraph)).Map(new StyleMapAnonymous1());
        }

        public IOptional<IHtmlPath> GetRunHtmlPath(Run run)
        {
            return Iterables.TryFind(_runStyles, new StyleMapAnonymous2(run)).Map(new StyleMapAnonymous3());
        }

        public IOptional<IHtmlPath> GetTableHtmlPath(Table table)
        {
            return Iterables.TryFind(_tableStyles, new StyleMapAnonymous4(table)).Map(new StyleMapAnonymous5());
        }

        public IOptional<IHtmlPath> GetBreakHtmlPath(Break breakElement)
        {
            return Iterables.TryFind(_breakStyles, new StyleMapAnonymous6(breakElement)).Map(new StyleMapAnonymous7());
        }
    }
}
