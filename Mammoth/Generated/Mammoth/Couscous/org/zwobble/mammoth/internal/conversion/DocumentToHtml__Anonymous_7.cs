namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_7 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._run = run;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._run, this._context);
        }
    }
}

