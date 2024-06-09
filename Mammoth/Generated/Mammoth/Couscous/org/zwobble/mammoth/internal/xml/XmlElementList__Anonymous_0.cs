namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>> {
        internal string _name;
        internal XmlElementList__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return element.findChildren(this._name);
        }
    }
}

