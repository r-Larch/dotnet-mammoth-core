namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class ElementName {
        internal string _localName;
        internal string _uri;

        internal ElementName(string uri, string localName)
        {
            _uri = uri;
            _localName = localName;
        }

        public string getUri()
        {
            return _uri;
        }

        public string getLocalName()
        {
            return _localName;
        }
    }
}
