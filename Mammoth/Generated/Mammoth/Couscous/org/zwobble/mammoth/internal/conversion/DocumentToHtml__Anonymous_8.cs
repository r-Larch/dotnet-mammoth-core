using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_8 : Supplier<HtmlPath> {
        private Run _run;
        private DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_8(Run run, DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)
        {
            _run = run;
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }

        public HtmlPath get()
        {
            if (((_run).getStyle()).isPresent()) {
                ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised run style: " + (((_run).getStyle()).get()).describe());
            }

            return HtmlPath_static._EMPTY;
        }
    }
}
