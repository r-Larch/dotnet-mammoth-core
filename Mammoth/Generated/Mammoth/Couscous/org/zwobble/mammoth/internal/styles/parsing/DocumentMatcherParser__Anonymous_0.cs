namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_0 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _paragraph;
        internal DocumentMatcherParser__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph) {
            this._paragraph = paragraph;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapParagraph(this._paragraph, path);
        }
    }
}

