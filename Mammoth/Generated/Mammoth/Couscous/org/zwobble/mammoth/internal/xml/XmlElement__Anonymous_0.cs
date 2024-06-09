namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _name;
        internal XmlElement__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Element has no '" + this._name) + "' attribute");
        }
    }
}

