using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous19 : IFunction<string, IList<IHtmlNode>> {
        private Image _image;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous19(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml, Image image)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
            _image = image;
        }

        public IList<IHtmlNode> Apply(string contentType)
        {
            try {
                IMap<string, string> attributes = new HashMap<string, string>(((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ImageConverter).Convert(new DocumentToHtmlAnonymous17(_image, contentType)));
                ((_image).GetAltText()).IfPresent(new DocumentToHtmlAnonymous18(attributes));
                return Lists.List(Html.Element("img", attributes));
            }
            catch (IoException exception) {
                ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).Warnings).Add(exception.GetMessage());
                return Lists.List<IHtmlNode>();
            }
        }
    }
}
