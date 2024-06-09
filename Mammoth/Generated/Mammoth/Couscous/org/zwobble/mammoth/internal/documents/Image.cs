namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Image : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal Mammoth.Couscous.java.util.Optional<string> _contentType;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier _open;
        internal Image(Mammoth.Couscous.java.util.Optional<string> altText, Mammoth.Couscous.java.util.Optional<string> contentType, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier open) {
            this._altText = altText;
            this._contentType = contentType;
            this._open = open;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAltText() {
            return this._altText;
        }
        public Mammoth.Couscous.java.util.Optional<string> getContentType() {
            return this._contentType;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return (this._open).open();
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

