namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal DocumentXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._bodyReader = bodyReader;
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike body = element.findChildOrEmpty("w:body");
            return (((this._bodyReader).readElements(body.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader__Anonymous_0(this));
        }
    }
}

