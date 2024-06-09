using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous15 : IFunction<IList<IDocumentElement>, IDocumentElement> {
        private bool _isHeader;

        internal StatefulBodyXmlReaderAnonymous15(bool isHeader)
        {
            _isHeader = isHeader;
        }

        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return new TableRow(children, _isHeader);
        }
    }
}
