namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NoteReference : DocumentElement {
        private string _noteId;
        private NoteType _noteType;

        internal NoteReference(NoteType noteType, string noteId)
        {
            _noteType = noteType;
            _noteId = noteId;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public static NoteReference footnoteReference(string noteId)
        {
            return new NoteReference(NoteType._FOOTNOTE, noteId);
        }

        public static NoteReference endnoteReference(string noteId)
        {
            return new NoteReference(NoteType._ENDNOTE, noteId);
        }

        public NoteType getNoteType()
        {
            return _noteType;
        }

        public string getNoteId()
        {
            return _noteId;
        }
    }
}
