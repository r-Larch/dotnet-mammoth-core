namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> {
        internal Mammoth.Couscous.java.util.Optional<string> _prefix;
        internal NamespacePrefixes__Anonymous_0(Mammoth.Couscous.java.util.Optional<string> prefix) {
            this._prefix = prefix;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix @namespace) {
            return (@namespace.getPrefix()).equals(this._prefix);
        }
    }
}

