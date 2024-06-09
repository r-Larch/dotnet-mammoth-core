using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_15 : Function<List<DocumentElement>, DocumentElement> {
        internal bool _isHeader;

        internal StatefulBodyXmlReader__Anonymous_15(bool isHeader)
        {
            _isHeader = isHeader;
        }

        public DocumentElement apply(List<DocumentElement> children)
        {
            return new TableRow(children, _isHeader);
        }
    }
}
