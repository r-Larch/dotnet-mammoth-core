namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList : Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> _elements;
        internal XmlElementList(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> elements) {
            this._elements = elements;
        }
        public Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> iterator() {
            return (this._elements).iterator();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList findChildren(string name) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList__Anonymous_0(name)));
        }
    }
}

