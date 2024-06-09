using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_4 : Predicate<StyleMapping<Table>> {
        internal Table _table;

        internal StyleMap__Anonymous_4(Table table)
        {
            _table = table;
        }

        public bool test(StyleMapping<Table> styleMapping)
        {
            return styleMapping.matches(_table);
        }
    }
}
