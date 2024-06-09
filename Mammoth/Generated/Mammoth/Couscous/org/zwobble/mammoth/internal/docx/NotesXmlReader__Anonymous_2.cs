using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_2 : Function<string, bool> {
        private NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;

        internal NotesXmlReader__Anonymous_2(NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }

        public bool apply(string type)
        {
            return !(_this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isSeparatorType(type);
        }
    }
}
