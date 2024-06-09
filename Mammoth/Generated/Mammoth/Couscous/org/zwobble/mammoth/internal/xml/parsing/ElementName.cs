namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class ElementName {
        private string _localName;
        private string _uri;

        internal ElementName(string uri, string localName)
        {
            _uri = uri;
            _localName = localName;
        }

        public string GetUri()
        {
            return _uri;
        }

        public string GetLocalName()
        {
            return _localName;
        }
    }
}
