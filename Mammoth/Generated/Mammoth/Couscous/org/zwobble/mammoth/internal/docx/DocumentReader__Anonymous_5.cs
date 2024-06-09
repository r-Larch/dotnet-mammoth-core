using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_5 : BiFunction<XmlElement, BodyXmlReader, InternalResult<List<Comment>>> {
        public InternalResult<List<Comment>> apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return (new CommentXmlReader(bodyReader)).readElement(root);
        }
    }
}
