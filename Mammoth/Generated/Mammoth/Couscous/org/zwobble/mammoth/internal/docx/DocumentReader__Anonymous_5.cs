namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_5 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader(bodyReader)).readElement(root);
        }
    }
}

