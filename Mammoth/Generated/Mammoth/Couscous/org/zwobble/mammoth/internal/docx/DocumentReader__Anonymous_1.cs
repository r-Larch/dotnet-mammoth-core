namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_1 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader _partReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths _partPaths;
        internal DocumentReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader partReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths) {
            this._partReader = partReader;
            this._partPaths = partPaths;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            return (this._partReader).readPart<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>>((this._partPaths).getMainDocument(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_0(notes, comments), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>>());
        }
    }
}

