using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_3 : Supplier<string> {
        private ElementName _name;

        internal XmlParser__Anonymous_3(ElementName name)
        {
            _name = name;
        }

        public string get()
        {
            return (("{" + (_name).getUri()) + "}") + (_name).getLocalName();
        }
    }
}
