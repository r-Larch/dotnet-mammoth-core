using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_14 : Function<InputStream, XmlElement> {
        public XmlElement apply(InputStream arg0)
        {
            return OfficeXml.parseXml(arg0);
        }
    }
}
