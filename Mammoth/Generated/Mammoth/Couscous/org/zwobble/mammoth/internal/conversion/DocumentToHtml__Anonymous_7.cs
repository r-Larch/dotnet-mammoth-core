using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous7 : ISupplier<IList<IHtmlNode>> {
        private DocumentToHtmlContext _context;
        private Run _run;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous7(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, Run run, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _run = run;
            _context = context;
        }

        public IList<IHtmlNode> Get()
        {
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertChildrenToHtml(_run, _context);
        }
    }
}
