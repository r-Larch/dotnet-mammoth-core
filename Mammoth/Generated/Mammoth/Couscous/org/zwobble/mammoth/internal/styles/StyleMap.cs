namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _EMPTY;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _smallCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> _tableStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        static StyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY = (new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder()).build();
        }
        internal StyleMap(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> bold, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> italic, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> underline, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> strikethrough, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> smallCaps, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> commentReference, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> paragraphStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> runStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> tableStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> breakStyles) {
            this._bold = bold;
            this._italic = italic;
            this._underline = underline;
            this._strikethrough = strikethrough;
            this._smallCaps = smallCaps;
            this._commentReference = commentReference;
            this._paragraphStyles = paragraphStyles;
            this._runStyles = runStyles;
            this._tableStyles = tableStyles;
            this._breakStyles = breakStyles;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap merge(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap high, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap low) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._bold, low._bold), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._italic, low._italic), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._underline, low._underline), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._strikethrough, low._strikethrough), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._smallCaps, low._smallCaps), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._commentReference, low._commentReference), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(high._paragraphStyles, low._paragraphStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(high._runStyles, low._runStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>(high._tableStyles, low._tableStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(high._breakStyles, low._breakStyles));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap update(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap.merge(styleMap, this);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getBold() {
            return this._bold;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getItalic() {
            return this._italic;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getUnderline() {
            return this._underline;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getStrikethrough() {
            return this._strikethrough;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getSmallCaps() {
            return this._smallCaps;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getCommentReference() {
            return this._commentReference;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getParagraphHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(this._paragraphStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_0(paragraph))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_1());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getRunHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(this._runStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_2(run))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_3());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getTableHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>(this._tableStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_4(table))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_5());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getBreakHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(this._breakStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_6(breakElement))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_7());
        }
    }
}

