namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_6 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._paragraph = paragraph;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._paragraph).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised paragraph style: " + (((this._paragraph).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("p");
        }
    }
}

