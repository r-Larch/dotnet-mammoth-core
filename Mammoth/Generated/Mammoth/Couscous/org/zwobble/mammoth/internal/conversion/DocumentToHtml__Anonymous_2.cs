using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous2 : IFunction<Note, IHtmlNode> {
        private DocumentToHtmlContext _context;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous2(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, DocumentToHtmlContext context)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _context = context;
        }

        public IHtmlNode Apply(Note note)
        {
            return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml(note, _context);
        }
    }
}
