using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous1 : IBiFunction<Notes, IList<Comment>, InternalResult<Document>> {
        private DocumentReaderPartPaths _partPaths;
        private DocumentReaderPartWithBodyReader _partReader;

        internal DocumentReaderAnonymous1(DocumentReaderPartWithBodyReader partReader, DocumentReaderPartPaths partPaths)
        {
            _partReader = partReader;
            _partPaths = partPaths;
        }

        public InternalResult<Document> Apply(Notes notes, IList<Comment> comments)
        {
            return (_partReader).ReadPart((_partPaths).GetMainDocument(), new DocumentReaderAnonymous0(notes, comments), Optional.Empty<InternalResult<Document>>());
        }
    }
}
