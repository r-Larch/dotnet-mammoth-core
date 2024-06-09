namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_10 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal InternalDocumentConverter__Anonymous_10(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            this._zipFile = zipFile;
        }
        public Mammoth.Couscous.java.util.Optional<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.readStyleMap(this._zipFile);
        }
    }
}

