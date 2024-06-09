using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml__Anonymous_1 : Function<XmlElement, Map__Entry<string, string>> {
        public Map__Entry<string, string> apply(XmlElement arg0)
        {
            return ContentTypesXml.readOverride(arg0);
        }
    }
}
