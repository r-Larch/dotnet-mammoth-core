using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous5 : ISupplier<IList<IHtmlNode>> {
        private DocumentToHtmlContext _context;
        private Paragraph _paragraph;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous5(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, Paragraph paragraph, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _paragraph = paragraph;
            _context = context;
        }

        public IList<IHtmlNode> Get()
        {
            var content = (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertChildrenToHtml(_paragraph, _context);
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).PreserveEmptyParagraphs ? Lists.Cons(Html.ForceWrite, content) : content;
        }
    }
}
