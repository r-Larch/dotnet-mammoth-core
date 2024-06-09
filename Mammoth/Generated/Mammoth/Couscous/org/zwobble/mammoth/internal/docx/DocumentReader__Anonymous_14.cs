using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous14 : IFunction<INputStream, XmlElement> {
        public XmlElement Apply(INputStream arg0)
        {
            return OfficeXml.ParseXml(arg0);
        }
    }
}
