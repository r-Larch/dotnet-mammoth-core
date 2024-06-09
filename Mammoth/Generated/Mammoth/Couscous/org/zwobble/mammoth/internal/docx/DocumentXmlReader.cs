using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader {
        internal BodyXmlReader _bodyReader;
        internal List<Comment> _comments;
        internal Notes _notes;

        internal DocumentXmlReader(BodyXmlReader bodyReader, Notes notes, List<Comment> comments)
        {
            _bodyReader = bodyReader;
            _notes = notes;
            _comments = comments;
        }

        public InternalResult<Document> readElement(XmlElement element)
        {
            var body = element.findChildOrEmpty("w:body");
            return (((_bodyReader).readElements(body.getChildren())).toResult()).map(new DocumentXmlReader__Anonymous_0(this));
        }
    }
}
