using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_5 : Supplier<List<HtmlNode>> {
        internal DocumentToHtml__Context _context;
        internal Paragraph _paragraph;
        internal DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_5(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Paragraph paragraph, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _paragraph = paragraph;
            _context = context;
        }

        public List<HtmlNode> get()
        {
            var content = (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(_paragraph, _context);
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._preserveEmptyParagraphs ? Lists.cons(Html._FORCE_WRITE, content) : content;
        }
    }
}
