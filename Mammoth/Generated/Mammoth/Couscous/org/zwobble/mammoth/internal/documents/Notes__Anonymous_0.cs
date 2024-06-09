using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NotesAnonymous0 : IFunction<Note, NoteType> {
        public NoteType Apply(Note arg0)
        {
            return arg0.GetNoteType();
        }
    }

    internal class NotesAnonymous1 : IFunction<Note, string> {
        public string Apply(Note arg0)
        {
            return arg0.GetId();
        }
    }

    internal class NotesAnonymous2 : IFunction<IList<Note>, IMap<string, Note>> {
        public IMap<string, Note> Apply(IList<Note> notesOfType)
        {
            return Maps.ToMapWithKey(notesOfType, new NotesAnonymous1());
        }
    }

    internal class NotesAnonymous3(string noteId) : IFunction<IMap<string, Note>, IOptional<Note>> {
        public IOptional<Note> Apply(IMap<string, Note> notesOfType)
        {
            return Maps.Lookup(notesOfType, noteId);
        }
    }
}
