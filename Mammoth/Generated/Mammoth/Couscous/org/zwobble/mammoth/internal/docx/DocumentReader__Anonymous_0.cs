using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_0 : BiFunction<XmlElement, BodyXmlReader, InternalResult<Document>> {
        internal List<Comment> _comments;
        internal Notes _notes;

        internal DocumentReader__Anonymous_0(Notes notes, List<Comment> comments)
        {
            _notes = notes;
            _comments = comments;
        }

        public InternalResult<Document> apply(XmlElement element, BodyXmlReader bodyReader)
        {
            return (new DocumentXmlReader(bodyReader, _notes, _comments)).readElement(element);
        }
    }
}
