using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_4 : Function<DocumentElement, Iterable<HtmlNode>> {
        internal DocumentToHtml__Context _context;
        internal DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_4(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _context = context;
        }

        public Iterable<HtmlNode> apply(DocumentElement element)
        {
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(element, _context);
        }
    }
}
