using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes {
        internal static Notes _EMPTY;
        internal Map<NoteType, Map<string, Note>> _notes;

        static Notes()
        {
            _EMPTY = new Notes(Lists.list<Note>());
        }

        internal Notes(List<Note> notes)
        {
            _notes = Maps.eagerMapValues(Maps.toMultiMapWithKey(notes, new Notes__Anonymous_0()), new Notes__Anonymous_2());
        }

        public Optional<Note> findNote(NoteType noteType, string noteId)
        {
            return (Maps.lookup(_notes, noteType)).flatMap(new Notes__Anonymous_3(noteId));
        }
    }
}
