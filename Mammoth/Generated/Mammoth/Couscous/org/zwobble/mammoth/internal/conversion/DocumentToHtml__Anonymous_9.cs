namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_9 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _breakElement;
        internal DocumentToHtml__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            this._breakElement = breakElement;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if ((this._breakElement).getType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("br");
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
            }
        }
    }
}

