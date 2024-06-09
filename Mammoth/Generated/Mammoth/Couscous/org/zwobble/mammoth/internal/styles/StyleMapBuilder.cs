namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _smallCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> _tableStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        internal StyleMapBuilder() {
            this._paragraphStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>();
            this._runStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>();
            this._tableStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>();
            this._breakStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>();
            this._bold = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._underline = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._strikethrough = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._smallCaps = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._italic = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._commentReference = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder bold(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._bold = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder italic(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._italic = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder underline(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._underline = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder strikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._strikethrough = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder smallCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._smallCaps = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder commentReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._commentReference = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._paragraphStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._runStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapTable(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._tableStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._breakStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(this._bold, this._italic, this._underline, this._strikethrough, this._smallCaps, this._commentReference, this._paragraphStyles, this._runStyles, this._tableStyles, this._breakStyles);
        }
    }
}

