using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementListAnonymous0(string name) : IFunction<XmlElement, ITerable<XmlElement>> {
        public ITerable<XmlElement> Apply(XmlElement element)
        {
            return element.FindChildren(name);
        }
    }
}
