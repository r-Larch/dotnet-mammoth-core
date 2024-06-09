using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTag {
        private Map<string, string> _attributes;
        private bool _isCollapsible;
        private string _separator;
        private List<string> _tagNames;

        internal HtmlTag(List<string> tagNames, Map<string, string> attributes, bool isCollapsible, string separator)
        {
            _tagNames = tagNames;
            _attributes = attributes;
            _isCollapsible = isCollapsible;
            _separator = separator;
        }

        public List<string> getTagNames()
        {
            return _tagNames;
        }

        public Map<string, string> getAttributes()
        {
            return _attributes;
        }

        public bool isCollapsible()
        {
            return _isCollapsible;
        }

        public string getSeparator()
        {
            return _separator;
        }
    }
}
