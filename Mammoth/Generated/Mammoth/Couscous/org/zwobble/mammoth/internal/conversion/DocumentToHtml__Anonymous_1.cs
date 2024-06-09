using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_1 : Function<NoteReference, Note> {
        private Document _document;

        internal DocumentToHtml__Anonymous_1(Document document)
        {
            _document = document;
        }

        public Note apply(NoteReference reference)
        {
            return (((_document).getNotes()).findNote(reference.getNoteType(), reference.getNoteId())).get();
        }
    }
}
