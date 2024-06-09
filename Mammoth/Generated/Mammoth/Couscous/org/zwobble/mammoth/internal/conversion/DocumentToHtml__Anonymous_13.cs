using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous13 : IFunction<TableRow, bool> {
        public bool Apply(TableRow arg0)
        {
            return arg0.IsHeader();
        }
    }
}
