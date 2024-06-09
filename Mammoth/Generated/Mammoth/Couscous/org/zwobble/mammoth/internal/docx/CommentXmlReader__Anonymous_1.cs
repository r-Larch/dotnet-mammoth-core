namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> {
        internal string _commentId;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal CommentXmlReader__Anonymous_1(string commentId, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            this._commentId = commentId;
            this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
            this._element = element;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment(this._commentId, children, (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(this._element, "w:author"), (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(this._element, "w:initials"));
        }
    }
}

