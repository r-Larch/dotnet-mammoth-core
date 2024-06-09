using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous4 : IFunction<IDocumentElement, ITerable<IHtmlNode>> {
        private DocumentToHtmlContext _context;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous4(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _context = context;
        }

        public ITerable<IHtmlNode> Apply(IDocumentElement element)
        {
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml(element, _context);
        }
    }
}
