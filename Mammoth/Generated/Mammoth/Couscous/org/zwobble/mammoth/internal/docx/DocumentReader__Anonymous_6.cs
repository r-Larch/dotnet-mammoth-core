namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_6 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.footnote(bodyReader)).readElement(root);
        }
    }
}

