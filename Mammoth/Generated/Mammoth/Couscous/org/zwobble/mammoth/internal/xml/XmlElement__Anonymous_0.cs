using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementAnonymous0(string name) : ISupplier<RuntimeException> {
        public RuntimeException Get()
        {
            return new RuntimeException($"Element has no '{name}' attribute");
        }
    }

    internal class XmlElementAnonymous1 : IFunction<IXmlNode, string> {
        public string Apply(IXmlNode arg0)
        {
            return arg0.InnerText();
        }
    }

    internal class XmlElementAnonymous2(string name) : IPredicate<XmlElement> {
        public bool Test(XmlElement child)
        {
            return child.GetName().Equals(name);
        }
    }
}
