using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParserAnonymous3 : ISupplier<string> {
        private ElementName _name;

        internal XmlParserAnonymous3(ElementName name)
        {
            _name = name;
        }

        public string Get()
        {
            return (("{" + (_name).GetUri()) + "}") + (_name).GetLocalName();
        }
    }
}
