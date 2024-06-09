using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous8 : ISupplier<IHtmlPath> {
        private Run _run;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous8(Run run, DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml)
        {
            _run = run;
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
        }

        public IHtmlPath Get()
        {
            if (((_run).GetStyle()).IsPresent()) {
                ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).Warnings).Add("Unrecognised run style: " + (((_run).GetStyle()).Get()).Describe());
            }

            return HtmlPathStatic.Empty;
        }
    }
}
