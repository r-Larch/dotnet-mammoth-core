using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal interface ISimpleSaxHandler {
        void StartElement(ElementName name, IMap<ElementName, string> attributes);
        void EndElement();
        void Characters(string @string);
    }
}
