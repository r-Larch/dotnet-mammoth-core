using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReaderAnonymous0(DocumentXmlReader reader) : IFunction<IList<IDocumentElement>, Document> {
        public Document Apply(IList<IDocumentElement> children)
        {
            return new Document(children, reader.Notes, reader.Comments);
        }
    }
}
