using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader__Anonymous_0 : Function<List<DocumentElement>, Document> {
        internal DocumentXmlReader _this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;

        internal DocumentXmlReader__Anonymous_0(DocumentXmlReader this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__DocumentXmlReader = this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        }

        public Document apply(List<DocumentElement> children)
        {
            return new Document(children, (_this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._notes, (_this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._comments);
        }
    }
}
