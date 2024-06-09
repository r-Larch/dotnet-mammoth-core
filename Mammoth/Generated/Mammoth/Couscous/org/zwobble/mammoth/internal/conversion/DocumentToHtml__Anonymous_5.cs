namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_5 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._paragraph = paragraph;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> content = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._paragraph, this._context);
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._preserveEmptyParagraphs ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, content) : content;
        }
    }
}

