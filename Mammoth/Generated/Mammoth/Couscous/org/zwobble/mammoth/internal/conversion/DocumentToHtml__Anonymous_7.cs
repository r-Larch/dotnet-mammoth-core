using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_7 : Supplier<List<HtmlNode>> {
        private DocumentToHtml__Context _context;
        private Run _run;
        private DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_7(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Run run, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _run = run;
            _context = context;
        }

        public List<HtmlNode> get()
        {
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(_run, _context);
        }
    }
}
