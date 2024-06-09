using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous8 : IBiFunction<IList<Note>, IList<Note>, IList<Note>> {
        public IList<Note> Apply(IList<Note> arg0, IList<Note> arg1)
        {
            return Lists.EagerConcat(arg0, arg1);
        }
    }
}
