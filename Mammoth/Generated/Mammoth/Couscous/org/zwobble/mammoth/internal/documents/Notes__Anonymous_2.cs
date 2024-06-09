using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NotesAnonymous2 : IFunction<IList<Note>, IMap<string, Note>> {
        public IMap<string, Note> Apply(IList<Note> notesOfType)
        {
            return Maps.ToMapWithKey(notesOfType, new NotesAnonymous1());
        }
    }
}
