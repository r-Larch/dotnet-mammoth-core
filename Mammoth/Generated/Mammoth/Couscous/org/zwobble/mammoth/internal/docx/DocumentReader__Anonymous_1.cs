using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_1 : BiFunction<Notes, List<Comment>, InternalResult<Document>> {
        private DocumentReader__PartPaths _partPaths;
        private DocumentReader__PartWithBodyReader _partReader;

        internal DocumentReader__Anonymous_1(DocumentReader__PartWithBodyReader partReader, DocumentReader__PartPaths partPaths)
        {
            _partReader = partReader;
            _partPaths = partPaths;
        }

        public InternalResult<Document> apply(Notes notes, List<Comment> comments)
        {
            return (_partReader).readPart((_partPaths).getMainDocument(), new DocumentReader__Anonymous_0(notes, comments), Optional.empty<InternalResult<Document>>());
        }
    }
}
