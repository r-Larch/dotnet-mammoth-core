using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes(IList<Note> notes) {
        public static Notes Empty = new(Lists.List<Note>());
        private readonly IMap<NoteType, IMap<string, Note>> _notes = Maps.EagerMapValues(Maps.ToMultiMapWithKey(notes, new NotesAnonymous0()), new NotesAnonymous2());

        public IOptional<Note> FindNote(NoteType noteType, string noteId)
        {
            return Maps.Lookup(_notes, noteType).FlatMap(new NotesAnonymous3(noteId));
        }
    }
}
