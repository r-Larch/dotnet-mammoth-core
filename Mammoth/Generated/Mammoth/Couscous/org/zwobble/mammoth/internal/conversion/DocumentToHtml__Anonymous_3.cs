using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous3 : IFunction<DocumentToHtmlReferencedComment, ITerable<IHtmlNode>> {
        private DocumentToHtmlContext _context;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous3(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _context = context;
        }

        public ITerable<IHtmlNode> Apply(DocumentToHtmlReferencedComment comment)
        {
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml(comment, _context);
        }
    }
}
