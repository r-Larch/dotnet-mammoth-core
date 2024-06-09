using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResultAnonymous1 : IFunction<ReadResult, ITerable<IDocumentElement>> {
        public ITerable<IDocumentElement> Apply(ReadResult result)
        {
            return result.Extra;
        }
    }
}
