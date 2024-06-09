using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementAnonymous1 : IFunction<IXmlNode, string> {
        public string Apply(IXmlNode arg0)
        {
            return arg0.InnerText();
        }
    }
}
