using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous16 : IFunction<IDocumentElement, string> {
        public string Apply(IDocumentElement node)
        {
            return InternalDocumentConverter.ExtractRawText(node);
        }
    }
}
