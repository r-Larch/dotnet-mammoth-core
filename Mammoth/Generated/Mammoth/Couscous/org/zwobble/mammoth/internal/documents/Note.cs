using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note {
        internal List<DocumentElement> _body;
        internal string _id;
        internal NoteType _noteType;

        internal Note(NoteType noteType, string id, List<DocumentElement> body)
        {
            _noteType = noteType;
            _id = id;
            _body = body;
        }

        public NoteType getNoteType()
        {
            return _noteType;
        }

        public string getId()
        {
            return _id;
        }

        public List<DocumentElement> getBody()
        {
            return _body;
        }
    }
}
