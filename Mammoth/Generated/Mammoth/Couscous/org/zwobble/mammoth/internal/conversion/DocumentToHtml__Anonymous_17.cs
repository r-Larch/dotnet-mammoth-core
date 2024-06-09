namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_17 : Mammoth.Couscous.org.zwobble.mammoth.images.Image {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal string _contentType;
        internal DocumentToHtml__Anonymous_17(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, string contentType) {
            this._image = image;
            this._contentType = contentType;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAltText() {
            return (this._image).getAltText();
        }
        public string getContentType() {
            return this._contentType;
        }
        public Mammoth.Couscous.java.io.InputStream getInputStream() {
            return (this._image).open();
        }
    }
}

