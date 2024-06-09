using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_3 : Function<List<DocumentElement>, Note> {
        private XmlElement _element;
        private NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;

        internal NotesXmlReader__Anonymous_3(NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader, XmlElement element)
        {
            _this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
            _element = element;
        }

        public Note apply(List<DocumentElement> children)
        {
            return new Note((_this_org__zwobble__mammoth__internal__docx__NotesXmlReader)._noteType, (_element).getAttribute("w:id"), children);
        }
    }
}
