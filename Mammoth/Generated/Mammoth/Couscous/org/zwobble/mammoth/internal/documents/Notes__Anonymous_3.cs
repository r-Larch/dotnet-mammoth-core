using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NotesAnonymous3 : IFunction<IMap<string, Note>, IOptional<Note>> {
        private string _noteId;

        internal NotesAnonymous3(string noteId)
        {
            _noteId = noteId;
        }

        public IOptional<Note> Apply(IMap<string, Note> notesOfType)
        {
            return Maps.Lookup(notesOfType, _noteId);
        }
    }
}
