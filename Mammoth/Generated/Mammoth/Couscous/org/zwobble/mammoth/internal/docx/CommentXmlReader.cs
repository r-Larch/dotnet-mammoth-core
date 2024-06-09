namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal CommentXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            this._bodyReader = bodyReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>(element.findChildren("w:comment"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader__Anonymous_0(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> readCommentElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string commentId = element.getAttribute("w:id");
            return (((this._bodyReader).readElements(element.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader__Anonymous_1(commentId, this, element));
        }
        public Mammoth.Couscous.java.util.Optional<string> readOptionalAttribute(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string name) {
            string value = ((element.getAttributeOrNone(name)).orElse("")).trim();
            if (value.isEmpty()) {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            } else {
                return Mammoth.Couscous.java.util.Optional.of<string>(value);
            }
        }
    }
}

