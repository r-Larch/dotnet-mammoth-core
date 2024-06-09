using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous5 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<IList<Comment>>> {
        public InternalResult<IList<Comment>> Apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return (new CommentXmlReader(bodyReader)).ReadElement(root);
        }
    }
}
