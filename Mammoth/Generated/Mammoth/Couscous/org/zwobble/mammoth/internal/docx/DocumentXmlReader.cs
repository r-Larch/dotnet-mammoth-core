using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader {
        private BodyXmlReader _bodyReader;
        public IList<Comment> Comments;
        public Notes Notes;

        internal DocumentXmlReader(BodyXmlReader bodyReader, Notes notes, IList<Comment> comments)
        {
            _bodyReader = bodyReader;
            Notes = notes;
            Comments = comments;
        }

        public InternalResult<Document> ReadElement(XmlElement element)
        {
            var body = element.FindChildOrEmpty("w:body");
            return (((_bodyReader).ReadElements(body.GetChildren())).ToResult()).Map(new DocumentXmlReaderAnonymous0(this));
        }
    }
}
