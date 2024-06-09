using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefix {
        private IOptional<string> _prefix;
        private string _uri;

        internal NamespacePrefix(IOptional<string> prefix, string uri)
        {
            _prefix = prefix;
            _uri = uri;
        }

        public IOptional<string> GetPrefix()
        {
            return _prefix;
        }

        public string GetUri()
        {
            return _uri;
        }
    }
}
