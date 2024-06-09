namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._context = context;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(note, this._context);
        }
    }
}

