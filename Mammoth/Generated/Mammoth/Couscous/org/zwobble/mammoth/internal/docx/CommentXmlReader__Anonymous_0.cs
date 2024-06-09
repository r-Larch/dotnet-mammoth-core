using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReaderAnonymous0(CommentXmlReader reader) : IFunction<XmlElement, InternalResult<Comment>> {
        public InternalResult<Comment> Apply(XmlElement arg0)
        {
            return reader.ReadCommentElement(arg0);
        }
    }

    internal class CommentXmlReaderAnonymous1(string commentId, CommentXmlReader reader, XmlElement element) : IFunction<IList<IDocumentElement>, Comment> {
        public Comment Apply(IList<IDocumentElement> children)
        {
            return new Comment(commentId, children, reader.ReadOptionalAttribute(element, "w:author"), reader.ReadOptionalAttribute(element, "w:initials"));
        }
    }
}
