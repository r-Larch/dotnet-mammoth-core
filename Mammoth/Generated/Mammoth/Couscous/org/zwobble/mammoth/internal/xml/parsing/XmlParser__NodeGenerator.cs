namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__NodeGenerator : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSaxHandler {
        internal Mammoth.Couscous.java.util.Deque<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder> _elementStack;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;
        internal XmlParser__NodeGenerator(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser this_org__zwobble__mammoth__internal__xml__parsing__XmlParser) {
            this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;
            this._elementStack = new Mammoth.Couscous.java.util.ArrayDeque<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement getRoot() {
            return ((this._elementStack).getFirst()).build();
        }
        public void startElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> attributes) {
            Mammoth.Couscous.java.util.Map<string, string> simpleAttributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapKeys<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string, string>(attributes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_0(this));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder element = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder(this.readName(name), simpleAttributes);
            (this._elementStack).add(element);
        }
        public string readName(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            if (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.isNullOrEmpty(name.getUri())) {
                return name.getLocalName();
            } else {
                return ((((this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser)._namespaces).lookupUri(name.getUri())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_2(name))).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_3(name));
            }
        }
        public void endElement() {
            if ((this._elementStack).size() > 1) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder element = (this._elementStack).removeLast();
                ((this._elementStack).getLast()).addChild(element.build());
            }
        }
        public void characters(string @string) {
            ((this._elementStack).getLast()).addChild(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode(@string));
        }
    }
}

