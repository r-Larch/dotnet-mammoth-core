using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_0 : BiConsumer<StyleMapBuilder, HtmlPath> {
        internal ParagraphMatcher _paragraph;

        internal DocumentMatcherParser__Anonymous_0(ParagraphMatcher paragraph)
        {
            _paragraph = paragraph;
        }

        public void accept(StyleMapBuilder builder, HtmlPath path)
        {
            builder.mapParagraph(_paragraph, path);
        }
    }
}
