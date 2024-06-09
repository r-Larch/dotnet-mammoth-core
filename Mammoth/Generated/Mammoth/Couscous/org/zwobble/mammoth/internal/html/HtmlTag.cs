using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTag(IList<string> tagNames, IMap<string, string> attributes, bool isCollapsible, string separator) {
        public IList<string> GetTagNames()
        {
            return tagNames;
        }

        public IMap<string, string> GetAttributes()
        {
            return attributes;
        }

        public bool IsCollapsible()
        {
            return isCollapsible;
        }

        public string GetSeparator()
        {
            return separator;
        }
    }
}
