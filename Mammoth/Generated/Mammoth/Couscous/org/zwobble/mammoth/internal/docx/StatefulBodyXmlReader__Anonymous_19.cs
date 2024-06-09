using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_19 : Function<XmlElement, bool> {
        public bool apply(XmlElement element)
        {
            return ((element.getAttributeOrNone("w:val")).map(new StatefulBodyXmlReader__Anonymous_18())).orElse(true);
        }
    }
}
