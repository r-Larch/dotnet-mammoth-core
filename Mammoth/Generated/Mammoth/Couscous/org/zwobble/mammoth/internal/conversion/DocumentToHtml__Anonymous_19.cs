using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_19 : Function<string, List<HtmlNode>> {
        private Image _image;
        private DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_19(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Image image)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _image = image;
        }

        public List<HtmlNode> apply(string contentType)
        {
            try {
                Map<string, string> attributes = new HashMap<string, string>(((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._imageConverter).convert(new DocumentToHtml__Anonymous_17(_image, contentType)));
                ((_image).getAltText()).ifPresent(new DocumentToHtml__Anonymous_18(attributes));
                return Lists.list(Html.element("img", attributes));
            }
            catch (IOException exception) {
                ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add(exception.getMessage());
                return Lists.list<HtmlNode>();
            }
        }
    }
}
