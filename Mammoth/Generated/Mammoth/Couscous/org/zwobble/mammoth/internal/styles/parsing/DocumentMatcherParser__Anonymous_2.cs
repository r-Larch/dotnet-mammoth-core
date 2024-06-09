using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParserAnonymous2 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        private TableMatcher _table;

        internal DocumentMatcherParserAnonymous2(TableMatcher table)
        {
            _table = table;
        }

        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapTable(_table, path);
        }
    }
}
