namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Builder {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> _uriToPrefix;
        internal NamespacePrefixes__Builder() {
            this._uriToPrefix = new Mammoth.Couscous.java.util.HashMap<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder put(string prefix, string uri) {
            (this._uriToPrefix).put(uri, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix(Mammoth.Couscous.java.util.Optional.of<string>(prefix), uri));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder defaultPrefix(string uri) {
            (this._uriToPrefix).put(uri, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix(Mammoth.Couscous.java.util.Optional.empty<string>(), uri));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes(this._uriToPrefix);
        }
    }
}

