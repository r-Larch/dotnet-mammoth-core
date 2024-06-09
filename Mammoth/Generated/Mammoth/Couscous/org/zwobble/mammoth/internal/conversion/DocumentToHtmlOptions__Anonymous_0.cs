namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.images.Image _image;
        internal DocumentToHtmlOptions__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
            this._image = image;
        }
        public Mammoth.Couscous.java.io.InputStream get() {
            return (this._image).getInputStream();
        }
    }
}

