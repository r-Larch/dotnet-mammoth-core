using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReaderAnonymous0 : IFunction<XmlElement, InternalResult<Comment>> {
        private CommentXmlReader _thisOrgZwobbleMammothInternalDocxCommentXmlReader;

        internal CommentXmlReaderAnonymous0(CommentXmlReader thisOrgZwobbleMammothInternalDocxCommentXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxCommentXmlReader = thisOrgZwobbleMammothInternalDocxCommentXmlReader;
        }

        public InternalResult<Comment> Apply(XmlElement arg0)
        {
            return (_thisOrgZwobbleMammothInternalDocxCommentXmlReader).ReadCommentElement(arg0);
        }
    }
}
