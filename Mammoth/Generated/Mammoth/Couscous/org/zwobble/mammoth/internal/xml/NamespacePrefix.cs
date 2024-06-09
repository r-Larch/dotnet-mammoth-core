using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefix {
        private Optional<string> _prefix;
        private string _uri;

        internal NamespacePrefix(Optional<string> prefix, string uri)
        {
            _prefix = prefix;
            _uri = uri;
        }

        public Optional<string> getPrefix()
        {
            return _prefix;
        }

        public string getUri()
        {
            return _uri;
        }
    }
}
