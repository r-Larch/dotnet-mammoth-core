using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note {
        private IList<IDocumentElement> _body;
        private string _id;
        private NoteType _noteType;

        internal Note(NoteType noteType, string id, IList<IDocumentElement> body)
        {
            _noteType = noteType;
            _id = id;
            _body = body;
        }

        public NoteType GetNoteType()
        {
            return _noteType;
        }

        public string GetId()
        {
            return _id;
        }

        public IList<IDocumentElement> GetBody()
        {
            return _body;
        }
    }
}
