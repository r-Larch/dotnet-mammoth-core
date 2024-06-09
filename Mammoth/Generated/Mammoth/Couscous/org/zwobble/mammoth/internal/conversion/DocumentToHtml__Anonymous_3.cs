using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_3 : Function<DocumentToHtml__ReferencedComment, Iterable<HtmlNode>> {
        private DocumentToHtml__Context _context;
        private DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_3(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _context = context;
        }

        public Iterable<HtmlNode> apply(DocumentToHtml__ReferencedComment comment)
        {
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(comment, _context);
        }
    }
}
