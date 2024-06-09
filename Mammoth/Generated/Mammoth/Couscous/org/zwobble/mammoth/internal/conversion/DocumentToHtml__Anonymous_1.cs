using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous1 : IFunction<NoteReference, Note> {
        private Document _document;

        internal DocumentToHtmlAnonymous1(Document document)
        {
            _document = document;
        }

        public Note Apply(NoteReference reference)
        {
            return (((_document).GetNotes()).FindNote(reference.GetNoteType(), reference.GetNoteId())).Get();
        }
    }
}
