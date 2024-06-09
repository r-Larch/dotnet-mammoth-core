using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
        private Optional<HtmlPath> _bold;
        private List<StyleMapping<Break>> _breakStyles;
        private Optional<HtmlPath> _commentReference;
        private Optional<HtmlPath> _italic;
        private List<StyleMapping<Paragraph>> _paragraphStyles;
        private List<StyleMapping<Run>> _runStyles;
        private Optional<HtmlPath> _smallCaps;
        private Optional<HtmlPath> _strikethrough;
        private List<StyleMapping<Table>> _tableStyles;
        private Optional<HtmlPath> _underline;

        internal StyleMapBuilder()
        {
            _paragraphStyles = new ArrayList<StyleMapping<Paragraph>>();
            _runStyles = new ArrayList<StyleMapping<Run>>();
            _tableStyles = new ArrayList<StyleMapping<Table>>();
            _breakStyles = new ArrayList<StyleMapping<Break>>();
            _bold = Optional.empty<HtmlPath>();
            _underline = Optional.empty<HtmlPath>();
            _strikethrough = Optional.empty<HtmlPath>();
            _smallCaps = Optional.empty<HtmlPath>();
            _italic = Optional.empty<HtmlPath>();
            _commentReference = Optional.empty<HtmlPath>();
        }

        public StyleMapBuilder bold(HtmlPath path)
        {
            _bold = Optional.of(path);
            return this;
        }

        public StyleMapBuilder italic(HtmlPath path)
        {
            _italic = Optional.of(path);
            return this;
        }

        public StyleMapBuilder underline(HtmlPath path)
        {
            _underline = Optional.of(path);
            return this;
        }

        public StyleMapBuilder strikethrough(HtmlPath path)
        {
            _strikethrough = Optional.of(path);
            return this;
        }

        public StyleMapBuilder smallCaps(HtmlPath path)
        {
            _smallCaps = Optional.of(path);
            return this;
        }

        public StyleMapBuilder commentReference(HtmlPath path)
        {
            _commentReference = Optional.of(path);
            return this;
        }

        public StyleMapBuilder mapParagraph(ParagraphMatcher matcher, HtmlPath path)
        {
            (_paragraphStyles).add(new StyleMapping<Paragraph>(matcher, path));
            return this;
        }

        public StyleMapBuilder mapRun(RunMatcher matcher, HtmlPath path)
        {
            (_runStyles).add(new StyleMapping<Run>(matcher, path));
            return this;
        }

        public StyleMapBuilder mapTable(TableMatcher matcher, HtmlPath path)
        {
            (_tableStyles).add(new StyleMapping<Table>(matcher, path));
            return this;
        }

        public StyleMapBuilder mapBreak(BreakMatcher matcher, HtmlPath path)
        {
            (_breakStyles).add(new StyleMapping<Break>(matcher, path));
            return this;
        }

        public StyleMap build()
        {
            return new StyleMap(_bold, _italic, _underline, _strikethrough, _smallCaps, _commentReference, _paragraphStyles, _runStyles, _tableStyles, _breakStyles);
        }
    }
}
