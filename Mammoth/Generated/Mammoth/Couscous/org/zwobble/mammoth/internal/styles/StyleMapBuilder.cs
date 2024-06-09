using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
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

        internal StyleMapBuilder()
        {
            _paragraphStyles = new ArrayList<StyleMapping<Paragraph>>();
            _runStyles = new ArrayList<StyleMapping<Run>>();
            _tableStyles = new ArrayList<StyleMapping<Table>>();
            _breakStyles = new ArrayList<StyleMapping<Break>>();
            _bold = Optional.Empty<IHtmlPath>();
            _underline = Optional.Empty<IHtmlPath>();
            _strikethrough = Optional.Empty<IHtmlPath>();
            _smallCaps = Optional.Empty<IHtmlPath>();
            _italic = Optional.Empty<IHtmlPath>();
            _commentReference = Optional.Empty<IHtmlPath>();
        }

        public StyleMapBuilder Bold(IHtmlPath path)
        {
            _bold = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder Italic(IHtmlPath path)
        {
            _italic = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder Underline(IHtmlPath path)
        {
            _underline = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder Strikethrough(IHtmlPath path)
        {
            _strikethrough = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder SmallCaps(IHtmlPath path)
        {
            _smallCaps = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder CommentReference(IHtmlPath path)
        {
            _commentReference = Optional.Of(path);
            return this;
        }

        public StyleMapBuilder MapParagraph(ParagraphMatcher matcher, IHtmlPath path)
        {
            (_paragraphStyles).Add(new StyleMapping<Paragraph>(matcher, path));
            return this;
        }

        public StyleMapBuilder MapRun(RunMatcher matcher, IHtmlPath path)
        {
            (_runStyles).Add(new StyleMapping<Run>(matcher, path));
            return this;
        }

        public StyleMapBuilder MapTable(TableMatcher matcher, IHtmlPath path)
        {
            (_tableStyles).Add(new StyleMapping<Table>(matcher, path));
            return this;
        }

        public StyleMapBuilder MapBreak(BreakMatcher matcher, IHtmlPath path)
        {
            (_breakStyles).Add(new StyleMapping<Break>(matcher, path));
            return this;
        }

        public StyleMap Build()
        {
            return new StyleMap(_bold, _italic, _underline, _strikethrough, _smallCaps, _commentReference, _paragraphStyles, _runStyles, _tableStyles, _breakStyles);
        }
    }
}
