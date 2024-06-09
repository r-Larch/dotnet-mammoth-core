using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_3 : Function<Map<string, Note>, Optional<Note>> {
        private string _noteId;

        internal Notes__Anonymous_3(string noteId)
        {
            _noteId = noteId;
        }

        public Optional<Note> apply(Map<string, Note> notesOfType)
        {
            return Maps.lookup(notesOfType, _noteId);
        }
    }
}
