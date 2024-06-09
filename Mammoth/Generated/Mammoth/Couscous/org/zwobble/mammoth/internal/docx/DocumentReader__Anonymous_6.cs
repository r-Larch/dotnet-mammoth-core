using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous6 : IBiFunction<XmlElement, BodyXmlReader, InternalResult<IList<Note>>> {
        public InternalResult<IList<Note>> Apply(XmlElement root, BodyXmlReader bodyReader)
        {
            return (NotesXmlReader.Footnote(bodyReader)).ReadElement(root);
        }
    }
}
