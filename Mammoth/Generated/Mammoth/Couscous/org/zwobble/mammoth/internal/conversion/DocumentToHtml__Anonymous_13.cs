using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_13 : Function<TableRow, bool> {
        public bool apply(TableRow arg0)
        {
            return arg0.isHeader();
        }
    }
}
