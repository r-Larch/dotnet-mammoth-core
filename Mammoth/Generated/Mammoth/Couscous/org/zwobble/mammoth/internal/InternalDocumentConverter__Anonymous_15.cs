using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous15 : IFunction<Document, string> {
        public string Apply(Document arg0)
        {
            return InternalDocumentConverter.ExtractRawTextOfChildren(arg0);
        }
    }
}
