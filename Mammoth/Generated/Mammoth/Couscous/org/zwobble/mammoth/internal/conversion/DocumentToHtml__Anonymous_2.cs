using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_2 : Function<Note, HtmlNode> {
        internal DocumentToHtml__Context _context;
        internal DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_2(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            _context = context;
        }

        public HtmlNode apply(Note note)
        {
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(note, _context);
        }
    }
}
