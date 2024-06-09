namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        internal CommentXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readCommentElement(arg0);
        }
    }
}

