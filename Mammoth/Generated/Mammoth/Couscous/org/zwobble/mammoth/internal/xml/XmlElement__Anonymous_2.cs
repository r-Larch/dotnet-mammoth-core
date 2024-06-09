namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _name;
        internal XmlElement__Anonymous_2(string name) {
            this._name = name;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return (child.getName()).Equals(this._name);
        }
    }
}

