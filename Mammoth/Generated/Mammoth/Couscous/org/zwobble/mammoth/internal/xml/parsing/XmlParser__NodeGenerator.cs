using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__NodeGenerator : SimpleSaxHandler {
        private Deque<XmlElementBuilder> _elementStack;
        private XmlParser _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;

        internal XmlParser__NodeGenerator(XmlParser this_org__zwobble__mammoth__internal__xml__parsing__XmlParser)
        {
            _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;
            _elementStack = new ArrayDeque<XmlElementBuilder>();
        }

        public void startElement(ElementName name, Map<ElementName, string> attributes)
        {
            var simpleAttributes = Maps.eagerMapKeys(attributes, new XmlParser__Anonymous_0(this));
            var element = new XmlElementBuilder(readName(name), simpleAttributes);
            (_elementStack).add(element);
        }

        public void endElement()
        {
            if ((_elementStack).size() > 1) {
                var element = (_elementStack).removeLast();
                ((_elementStack).getLast()).addChild(element.build());
            }
        }

        public void characters(string @string)
        {
            ((_elementStack).getLast()).addChild(new XmlTextNode(@string));
        }

        public XmlElement getRoot()
        {
            return ((_elementStack).getFirst()).build();
        }

        public string readName(ElementName name)
        {
            if (Strings.isNullOrEmpty(name.getUri())) {
                return name.getLocalName();
            }

            return ((((_this_org__zwobble__mammoth__internal__xml__parsing__XmlParser)._namespaces).lookupUri(name.getUri())).map(new XmlParser__Anonymous_2(name))).orElseGet(new XmlParser__Anonymous_3(name));
        }
    }
}
