using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_8 : BiFunction<List<Note>, List<Note>, List<Note>> {
        public List<Note> apply(List<Note> arg0, List<Note> arg1)
        {
            return Lists.eagerConcat(arg0, arg1);
        }
    }
}
