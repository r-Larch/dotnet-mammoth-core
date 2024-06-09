using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_0 : Function<XmlElement, InternalResult<Comment>> {
        internal CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;

        internal CommentXmlReader__Anonymous_0(CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        }

        public InternalResult<Comment> apply(XmlElement arg0)
        {
            return (_this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readCommentElement(arg0);
        }
    }
}
