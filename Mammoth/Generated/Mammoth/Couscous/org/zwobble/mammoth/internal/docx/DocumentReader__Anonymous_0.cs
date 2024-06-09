namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_0 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal DocumentReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader(bodyReader, this._notes, this._comments)).readElement(element);
        }
    }
}

