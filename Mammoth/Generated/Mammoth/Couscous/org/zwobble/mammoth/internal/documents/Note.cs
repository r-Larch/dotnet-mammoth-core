namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal string _id;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _body;
        internal Note(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string id, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> body) {
            this._noteType = noteType;
            this._id = id;
            this._body = body;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType getNoteType() {
            return this._noteType;
        }
        public string getId() {
            return this._id;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getBody() {
            return this._body;
        }
    }
}

