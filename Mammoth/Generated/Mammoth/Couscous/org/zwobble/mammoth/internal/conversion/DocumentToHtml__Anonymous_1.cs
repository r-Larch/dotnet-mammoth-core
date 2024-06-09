namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document _document;
        internal DocumentToHtml__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            this._document = document;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference reference) {
            return (((this._document).getNotes()).findNote(reference.getNoteType(), reference.getNoteId())).get();
        }
    }
}

