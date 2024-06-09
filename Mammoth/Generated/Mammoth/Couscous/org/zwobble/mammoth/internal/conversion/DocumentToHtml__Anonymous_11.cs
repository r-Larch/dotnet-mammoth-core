using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous11 : ISupplier<IList<IHtmlNode>> {
        private DocumentToHtmlContext _context;
        private Table _table;
        private DocumentToHtmlElementConverterVisitor _thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor;

        internal DocumentToHtmlAnonymous11(DocumentToHtmlElementConverterVisitor thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor, Table table, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor = thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor;
            _table = table;
            _context = context;
        }

        public IList<IHtmlNode> Get()
        {
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor).GenerateTableChildren(_table, _context);
        }
    }
}
