namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NoteReference(NoteType noteType, string noteId) : IDocumentElement {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public static NoteReference FootnoteReference(string noteId)
        {
            return new NoteReference(NoteType.Footnote, noteId);
        }

        public static NoteReference EndnoteReference(string noteId)
        {
            return new NoteReference(NoteType.Endnote, noteId);
        }

        public NoteType GetNoteType()
        {
            return noteType;
        }

        public string GetNoteId()
        {
            return noteId;
        }
    }
}
