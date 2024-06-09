using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_2 : Function<NamespacePrefix, string> {
        internal ElementName _name;

        internal XmlParser__Anonymous_2(ElementName name)
        {
            _name = name;
        }

        public string apply(NamespacePrefix @namespace)
        {
            return ((@namespace.getPrefix()).map(new XmlParser__Anonymous_1())).orElse("") + (_name).getLocalName();
        }
    }
}
