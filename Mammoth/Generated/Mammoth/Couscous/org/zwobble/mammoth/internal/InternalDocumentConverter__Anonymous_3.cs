namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_3 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.File _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_3(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._file = file;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._file, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_2(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter, this._file));
        }
    }
}

