using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_6 : Supplier<HtmlPath> {
        private Paragraph _paragraph;
        private DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_6(Paragraph paragraph, DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)
        {
            _paragraph = paragraph;
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }

        public HtmlPath get()
        {
            if (((_paragraph).getStyle()).isPresent()) {
                ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised paragraph style: " + (((_paragraph).getStyle()).get()).describe());
            }

            return HtmlPath_static.element("p");
        }
    }
}
