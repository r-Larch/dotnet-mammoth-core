using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes {
        public static Notes Empty;
        private IMap<NoteType, IMap<string, Note>> _notes;

        static Notes()
        {
            Empty = new Notes(Lists.List<Note>());
        }

        internal Notes(IList<Note> notes)
        {
            _notes = Maps.EagerMapValues(Maps.ToMultiMapWithKey(notes, new NotesAnonymous0()), new NotesAnonymous2());
        }

        public IOptional<Note> FindNote(NoteType noteType, string noteId)
        {
            return (Maps.Lookup(_notes, noteType)).FlatMap(new NotesAnonymous3(noteId));
        }
    }
}
