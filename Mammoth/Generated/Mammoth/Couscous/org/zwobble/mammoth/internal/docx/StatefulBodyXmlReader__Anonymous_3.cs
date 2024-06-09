using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous3 : IFunction<XmlElement, bool> {
        public bool Apply(XmlElement child)
        {
            return ((child.GetAttributeOrNone("w:val")).Map(new StatefulBodyXmlReaderAnonymous2())).OrElse(true);
        }
    }
}
