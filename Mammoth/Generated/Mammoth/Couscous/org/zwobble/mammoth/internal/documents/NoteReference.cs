namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NoteReference : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal string _noteId;
        internal NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            this._noteType = noteType;
            this._noteId = noteId;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference footnoteReference(string noteId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE, noteId);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference endnoteReference(string noteId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE, noteId);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType getNoteType() {
            return this._noteType;
        }
        public string getNoteId() {
            return this._noteId;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

