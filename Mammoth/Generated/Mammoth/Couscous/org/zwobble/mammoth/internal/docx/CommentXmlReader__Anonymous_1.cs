using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_1 : Function<List<DocumentElement>, Comment> {
        private string _commentId;
        private XmlElement _element;
        private CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;

        internal CommentXmlReader__Anonymous_1(string commentId, CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader, XmlElement element)
        {
            _commentId = commentId;
            _this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
            _element = element;
        }

        public Comment apply(List<DocumentElement> children)
        {
            return new Comment(_commentId, children, (_this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(_element, "w:author"), (_this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(_element, "w:initials"));
        }
    }
}
