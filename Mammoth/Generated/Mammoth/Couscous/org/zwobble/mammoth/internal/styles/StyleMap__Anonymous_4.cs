namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_4 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table _table;
        internal StyleMap__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            this._table = table;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table> styleMapping) {
            return styleMapping.matches(this._table);
        }
    }
}

