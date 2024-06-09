using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_16 : Function<DocumentElement, string> {
        public string apply(DocumentElement node)
        {
            return InternalDocumentConverter.extractRawText(node);
        }
    }
}
