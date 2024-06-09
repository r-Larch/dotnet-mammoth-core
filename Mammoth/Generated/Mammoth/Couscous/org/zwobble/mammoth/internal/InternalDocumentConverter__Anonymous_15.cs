using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_15 : Function<Document, string> {
        public string apply(Document arg0)
        {
            return InternalDocumentConverter.extractRawTextOfChildren(arg0);
        }
    }
}
