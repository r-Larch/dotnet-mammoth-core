using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParserAnonymous0 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        private ParagraphMatcher _paragraph;

        internal DocumentMatcherParserAnonymous0(ParagraphMatcher paragraph)
        {
            _paragraph = paragraph;
        }

        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapParagraph(_paragraph, path);
        }
    }
}
