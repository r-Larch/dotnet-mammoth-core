using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader {
        internal BodyXmlReader _bodyReader;

        internal CommentXmlReader(BodyXmlReader bodyReader)
        {
            _bodyReader = bodyReader;
        }

        public InternalResult<List<Comment>> readElement(XmlElement element)
        {
            return InternalResult.flatMap(element.findChildren("w:comment"), new CommentXmlReader__Anonymous_0(this));
        }

        public InternalResult<Comment> readCommentElement(XmlElement element)
        {
            var commentId = element.getAttribute("w:id");
            return (((_bodyReader).readElements(element.getChildren())).toResult()).map(new CommentXmlReader__Anonymous_1(commentId, this, element));
        }

        public Optional<string> readOptionalAttribute(XmlElement element, string name)
        {
            var value = ((element.getAttributeOrNone(name)).orElse("")).trim();
            if (value.isEmpty()) {
                return Optional.empty<string>();
            }

            return Optional.of(value);
        }
    }
}
