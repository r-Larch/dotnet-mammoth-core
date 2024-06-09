using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParserAnonymous2 : IFunction<NamespacePrefix, string> {
        private ElementName _name;

        internal XmlParserAnonymous2(ElementName name)
        {
            _name = name;
        }

        public string Apply(NamespacePrefix @namespace)
        {
            return ((@namespace.GetPrefix()).Map(new XmlParserAnonymous1())).OrElse("") + (_name).GetLocalName();
        }
    }
}
