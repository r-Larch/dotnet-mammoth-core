using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_2 : Function<List<Note>, Map<string, Note>> {
        public Map<string, Note> apply(List<Note> notesOfType)
        {
            return Maps.toMapWithKey(notesOfType, new Notes__Anonymous_1());
        }
    }
}
