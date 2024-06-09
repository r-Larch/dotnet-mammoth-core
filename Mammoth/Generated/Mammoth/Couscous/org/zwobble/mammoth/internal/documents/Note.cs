using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note(NoteType noteType, string id, IList<IDocumentElement> body) {
        public NoteType GetNoteType()
        {
            return noteType;
        }

        public string GetId()
        {
            return id;
        }

        public IList<IDocumentElement> GetBody()
        {
            return body;
        }
    }
}
