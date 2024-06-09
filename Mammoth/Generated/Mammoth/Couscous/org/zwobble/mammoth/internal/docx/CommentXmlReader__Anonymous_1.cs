using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReaderAnonymous1 : IFunction<IList<IDocumentElement>, Comment> {
        private string _commentId;
        private XmlElement _element;
        private CommentXmlReader _thisOrgZwobbleMammothInternalDocxCommentXmlReader;

        internal CommentXmlReaderAnonymous1(string commentId, CommentXmlReader thisOrgZwobbleMammothInternalDocxCommentXmlReader, XmlElement element)
        {
            _commentId = commentId;
            _thisOrgZwobbleMammothInternalDocxCommentXmlReader = thisOrgZwobbleMammothInternalDocxCommentXmlReader;
            _element = element;
        }

        public Comment Apply(IList<IDocumentElement> children)
        {
            return new Comment(_commentId, children, (_thisOrgZwobbleMammothInternalDocxCommentXmlReader).ReadOptionalAttribute(_element, "w:author"), (_thisOrgZwobbleMammothInternalDocxCommentXmlReader).ReadOptionalAttribute(_element, "w:initials"));
        }
    }
}
