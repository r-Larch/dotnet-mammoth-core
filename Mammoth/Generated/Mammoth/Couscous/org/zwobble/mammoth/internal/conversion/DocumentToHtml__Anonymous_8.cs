namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_8 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_8(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._run = run;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._run).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised run style: " + (((this._run).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
        }
    }
}

