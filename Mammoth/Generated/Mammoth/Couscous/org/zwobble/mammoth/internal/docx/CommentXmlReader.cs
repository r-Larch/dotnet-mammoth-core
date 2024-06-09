using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader(BodyXmlReader bodyReader) {
        public InternalResult<IList<Comment>> ReadElement(XmlElement element)
        {
            return InternalResult.FlatMap(element.FindChildren("w:comment"), new CommentXmlReaderAnonymous0(this));
        }

        public InternalResult<Comment> ReadCommentElement(XmlElement element)
        {
            var commentId = element.GetAttribute("w:id");
            return bodyReader.ReadElements(element.GetChildren()).ToResult().Map(new CommentXmlReaderAnonymous1(commentId, this, element));
        }

        public IOptional<string> ReadOptionalAttribute(XmlElement element, string name)
        {
            var value = JavaStringExtensions.Trim(element.GetAttributeOrNone(name).OrElse(""));
            if (value.IsEmpty()) {
                return Optional.Empty<string>();
            }

            return Optional.Of(value);
        }
    }
}
