using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_2 : BiConsumer<StyleMapBuilder, HtmlPath> {
        internal TableMatcher _table;

        internal DocumentMatcherParser__Anonymous_2(TableMatcher table)
        {
            _table = table;
        }

        public void accept(StyleMapBuilder builder, HtmlPath path)
        {
            builder.mapTable(_table, path);
        }
    }
}
