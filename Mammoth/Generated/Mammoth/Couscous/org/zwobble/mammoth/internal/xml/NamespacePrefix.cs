using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefix(IOptional<string> prefix, string uri) {
        public IOptional<string> GetPrefix()
        {
            return prefix;
        }

        public string GetUri()
        {
            return uri;
        }
    }
}
