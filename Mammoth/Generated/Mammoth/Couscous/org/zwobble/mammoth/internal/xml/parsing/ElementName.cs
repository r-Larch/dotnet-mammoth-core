namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class ElementName {
        internal string _uri;
        internal string _localName;
        internal ElementName(string uri, string localName) {
            this._uri = uri;
            this._localName = localName;
        }
        public string getUri() {
            return this._uri;
        }
        public string getLocalName() {
            return this._localName;
        }
    }
}

