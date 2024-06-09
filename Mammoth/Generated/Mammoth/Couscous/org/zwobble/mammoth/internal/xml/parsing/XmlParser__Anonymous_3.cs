namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_3 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string get() {
            return (("{" + (this._name).getUri()) + "}") + (this._name).getLocalName();
        }
    }
}

