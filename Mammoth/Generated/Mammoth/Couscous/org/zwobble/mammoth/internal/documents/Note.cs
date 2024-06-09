using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note {
        private List<DocumentElement> _body;
        private string _id;
        private NoteType _noteType;

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
