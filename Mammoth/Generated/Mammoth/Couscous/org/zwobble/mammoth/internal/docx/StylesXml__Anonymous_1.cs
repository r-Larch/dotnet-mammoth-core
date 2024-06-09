using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_1 : Function<XmlElement, Map__Entry<string, Style>> {
        public Map__Entry<string, Style> apply(XmlElement arg0)
        {
            return StylesXml.readStyle(arg0);
        }
    }
}
