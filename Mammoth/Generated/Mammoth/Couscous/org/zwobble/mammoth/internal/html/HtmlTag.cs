using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTag {
        private IMap<string, string> _attributes;
        private bool _isCollapsible;
        private string _separator;
        private IList<string> _tagNames;

        internal HtmlTag(IList<string> tagNames, IMap<string, string> attributes, bool isCollapsible, string separator)
        {
            _tagNames = tagNames;
            _attributes = attributes;
            _isCollapsible = isCollapsible;
            _separator = separator;
        }

        public IList<string> GetTagNames()
        {
            return _tagNames;
        }

        public IMap<string, string> GetAttributes()
        {
            return _attributes;
        }

        public bool IsCollapsible()
        {
            return _isCollapsible;
        }

        public string GetSeparator()
        {
            return _separator;
        }
    }
}
