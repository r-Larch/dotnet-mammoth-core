using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_1 : Function<XmlElement, Map__Entry<string, NumberingLevel>> {
        public Map__Entry<string, NumberingLevel> apply(XmlElement arg0)
        {
            return NumberingXml.readAbstractNumLevel(arg0);
        }
    }
}
