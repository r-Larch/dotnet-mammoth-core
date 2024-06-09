namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_2 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher _table;
        internal DocumentMatcherParser__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher table) {
            this._table = table;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapTable(this._table, path);
        }
    }
}

