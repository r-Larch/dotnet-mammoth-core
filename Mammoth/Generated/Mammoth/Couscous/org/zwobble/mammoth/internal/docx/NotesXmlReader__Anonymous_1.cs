using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_1 : Function<XmlElement, InternalResult<Note>> {
        private NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;

        internal NotesXmlReader__Anonymous_1(NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }

        public InternalResult<Note> apply(XmlElement arg0)
        {
            return (_this_org__zwobble__mammoth__internal__docx__NotesXmlReader).readNoteElement(arg0);
        }
    }
}
