using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous12 : IPredicate<IDocumentElement> {
        private DocumentToHtmlElementConverterVisitor _thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor;

        internal DocumentToHtmlAnonymous12(DocumentToHtmlElementConverterVisitor thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor = thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor;
        }

        public bool Test(IDocumentElement child)
        {
            return !(_thisOrgZwobbleMammothInternalConversionDocumentToHtmlElementConverterVisitor).IsHeader(child);
        }
    }
}
