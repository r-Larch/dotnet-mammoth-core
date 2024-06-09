using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal interface SimpleSaxHandler {
        void startElement(ElementName name, Map<ElementName, string> attributes);
        void endElement();
        void characters(string @string);
    }
}
