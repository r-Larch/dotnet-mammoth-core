namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal Mammoth.Couscous.java.io.File _file;
        internal InternalDocumentConverter__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, Mammoth.Couscous.java.io.File file) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            this._file = file;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.nio.file.Path>((this._file).toPath()), zipFile);
        }
    }
}

