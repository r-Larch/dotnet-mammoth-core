using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader(BodyXmlReader bodyReader, Notes notes, IList<Comment> comments) {
        public IList<Comment> Comments { get; } = comments;
        public Notes Notes { get; } = notes;

        public InternalResult<Document> ReadElement(XmlElement element)
        {
            var body = element.FindChildOrEmpty("w:body");
            return bodyReader.ReadElements(body.GetChildren()).ToResult().Map(new DocumentXmlReaderAnonymous0(this));
        }
    }
}
