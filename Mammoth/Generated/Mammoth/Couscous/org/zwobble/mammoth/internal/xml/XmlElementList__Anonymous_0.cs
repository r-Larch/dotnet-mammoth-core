using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList__Anonymous_0 : Function<XmlElement, Iterable<XmlElement>> {
        internal string _name;

        internal XmlElementList__Anonymous_0(string name)
        {
            _name = name;
        }

        public Iterable<XmlElement> apply(XmlElement element)
        {
            return element.findChildren(_name);
        }
    }
}
