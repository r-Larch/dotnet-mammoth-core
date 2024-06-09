using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous6 : ISupplier<IHtmlPath> {
        private Paragraph _paragraph;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous6(Paragraph paragraph, DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml)
        {
            _paragraph = paragraph;
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
        }

        public IHtmlPath Get()
        {
            if (((_paragraph).GetStyle()).IsPresent()) {
                ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).Warnings).Add("Unrecognised paragraph style: " + (((_paragraph).GetStyle()).Get()).Describe());
            }

            return HtmlPathStatic.Element("p");
        }
    }
}
