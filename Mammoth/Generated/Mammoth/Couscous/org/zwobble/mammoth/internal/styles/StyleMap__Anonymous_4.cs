using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous4 : IPredicate<StyleMapping<Table>> {
        private Table _table;

        internal StyleMapAnonymous4(Table table)
        {
            _table = table;
        }

        public bool Test(StyleMapping<Table> styleMapping)
        {
            return styleMapping.Matches(_table);
        }
    }
}
