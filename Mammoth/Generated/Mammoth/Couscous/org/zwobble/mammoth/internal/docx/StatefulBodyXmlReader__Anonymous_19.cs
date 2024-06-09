using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous19 : IFunction<XmlElement, bool> {
        public bool Apply(XmlElement element)
        {
            return ((element.GetAttributeOrNone("w:val")).Map(new StatefulBodyXmlReaderAnonymous18())).OrElse(true);
        }
    }
}
