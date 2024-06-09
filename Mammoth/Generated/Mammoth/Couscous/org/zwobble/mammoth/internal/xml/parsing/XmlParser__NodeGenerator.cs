using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParserNodeGenerator : ISimpleSaxHandler {
        private IDeque<XmlElementBuilder> _elementStack;
        private XmlParser _thisOrgZwobbleMammothInternalXmlParsingXmlParser;

        internal XmlParserNodeGenerator(XmlParser thisOrgZwobbleMammothInternalXmlParsingXmlParser)
        {
            _thisOrgZwobbleMammothInternalXmlParsingXmlParser = thisOrgZwobbleMammothInternalXmlParsingXmlParser;
            _elementStack = new ArrayDeque<XmlElementBuilder>();
        }

        public void StartElement(ElementName name, IMap<ElementName, string> attributes)
        {
            var simpleAttributes = Maps.EagerMapKeys(attributes, new XmlParserAnonymous0(this));
            var element = new XmlElementBuilder(ReadName(name), simpleAttributes);
            (_elementStack).Add(element);
        }

        public void EndElement()
        {
            if ((_elementStack).Size() > 1) {
                var element = (_elementStack).RemoveLast();
                ((_elementStack).GetLast()).AddChild(element.Build());
            }
        }

        public void Characters(string @string)
        {
            ((_elementStack).GetLast()).AddChild(new XmlTextNode(@string));
        }

        public XmlElement GetRoot()
        {
            return ((_elementStack).GetFirst()).Build();
        }

        public string ReadName(ElementName name)
        {
            if (Strings.IsNullOrEmpty(name.GetUri())) {
                return name.GetLocalName();
            }

            return ((((_thisOrgZwobbleMammothInternalXmlParsingXmlParser).Namespaces).LookupUri(name.GetUri())).Map(new XmlParserAnonymous2(name))).OrElseGet(new XmlParserAnonymous3(name));
        }
    }
}
