using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_0 : Predicate<XmlElement> {
        private NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;

        internal NotesXmlReader__Anonymous_0(NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }

        public bool test(XmlElement arg0)
        {
            return (_this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isNoteElement(arg0);
        }
    }
}
