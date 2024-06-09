namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.InputStream _stream;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_1(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._stream = stream;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._stream, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_0(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}

