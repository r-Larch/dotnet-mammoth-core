using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult__Anonymous_1 : Function<ReadResult, Iterable<DocumentElement>> {
        public Iterable<DocumentElement> apply(ReadResult result)
        {
            return result._extra;
        }
    }
}
