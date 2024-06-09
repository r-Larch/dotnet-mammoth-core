using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_3 : Function<XmlElement, bool> {
        public bool apply(XmlElement child)
        {
            return ((child.getAttributeOrNone("w:val")).map(new StatefulBodyXmlReader__Anonymous_2())).orElse(true);
        }
    }
}
