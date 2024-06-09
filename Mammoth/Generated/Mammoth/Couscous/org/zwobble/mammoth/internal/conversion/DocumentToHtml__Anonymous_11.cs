using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_11 : Supplier<List<HtmlNode>> {
        private DocumentToHtml__Context _context;
        private Table _table;
        private DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;

        internal DocumentToHtml__Anonymous_11(DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor, Table table, DocumentToHtml__Context context)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
            _table = table;
            _context = context;
        }

        public List<HtmlNode> get()
        {
            return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).generateTableChildren(_table, _context);
        }
    }
}
