using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_6 : BiFunction<XmlElement, BodyXmlReader, InternalResult<List<Note>>> {
        public InternalResult<List<Note>> apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return (NotesXmlReader.footnote(bodyReader)).readElement(root);
        }
    }
}
