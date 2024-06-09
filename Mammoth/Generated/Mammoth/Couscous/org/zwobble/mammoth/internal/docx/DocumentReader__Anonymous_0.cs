using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous0 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<Document>> {
        private IList<Comment> _comments;
        private Notes _notes;

        internal DocumentReaderAnonymous0(Notes notes, IList<Comment> comments)
        {
            _notes = notes;
            _comments = comments;
        }

        public InternalResult<Document> Apply(XmlElement element, BodyXmlReader bodyReader)
        {
            return (new DocumentXmlReader(bodyReader, _notes, _comments)).ReadElement(element);
        }
    }
}
