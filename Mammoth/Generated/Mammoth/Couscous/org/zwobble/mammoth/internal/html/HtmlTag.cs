namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTag {
        internal Mammoth.Couscous.java.util.List<string> _tagNames;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal bool _isCollapsible;
        internal string _separator;
        internal HtmlTag(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, bool isCollapsible, string separator) {
            this._tagNames = tagNames;
            this._attributes = attributes;
            this._isCollapsible = isCollapsible;
            this._separator = separator;
        }
        public Mammoth.Couscous.java.util.List<string> getTagNames() {
            return this._tagNames;
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
        }
        public bool isCollapsible() {
            return this._isCollapsible;
        }
        public string getSeparator() {
            return this._separator;
        }
    }
}

