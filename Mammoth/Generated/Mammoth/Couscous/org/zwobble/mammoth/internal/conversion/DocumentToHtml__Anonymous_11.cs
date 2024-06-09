namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_11 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table _table;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
            this._table = table;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).generateTableChildren(this._table, this._context);
        }
    }
}

