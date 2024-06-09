namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes : Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> _uriToPrefix;
        internal NamespacePrefixes(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> uriToPrefix) {
            this._uriToPrefix = uriToPrefix;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder();
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupUri(string uri) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>(this._uriToPrefix, uri);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupPrefix(string prefix) {
            return this.lookupPrefix(Mammoth.Couscous.java.util.Optional.of<string>(prefix));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> defaultNamespace() {
            return this.lookupPrefix(Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupPrefix(Mammoth.Couscous.java.util.Optional<string> prefix) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>((this._uriToPrefix).values(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Anonymous_0(prefix));
        }
        public Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> iterator() {
            return ((this._uriToPrefix).values()).iterator();
        }
    }
}

