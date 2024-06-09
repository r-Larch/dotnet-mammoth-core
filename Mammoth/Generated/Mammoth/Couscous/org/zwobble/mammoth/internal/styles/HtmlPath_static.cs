using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPath_static {
        public static HtmlPath _EMPTY;
        public static HtmlPath _IGNORE;

        static HtmlPath_static()
        {
            _EMPTY = new HtmlPathElements(Lists.list<HtmlPathElement>());
            _IGNORE = Ignore._INSTANCE;
        }

        public static HtmlPath elements(HtmlPathElement[] elements)
        {
            return new HtmlPathElements(Arrays.asList(elements));
        }

        public static HtmlPath element(string tagName)
        {
            return element(tagName, Maps.map<string, string>());
        }

        public static HtmlPath element(string tagName, Map<string, string> attributes)
        {
            var tag = new HtmlTag(Lists.list(tagName), attributes, false, "");
            return new HtmlPathElements(Lists.list(new HtmlPathElement(tag)));
        }

        public static HtmlPath collapsibleElement(string tagName)
        {
            return collapsibleElement(tagName, Maps.map<string, string>());
        }

        public static HtmlPath collapsibleElement(List<string> tagNames)
        {
            return collapsibleElement(tagNames, Maps.map<string, string>());
        }

        public static HtmlPath collapsibleElement(string tagName, Map<string, string> attributes)
        {
            return collapsibleElement(Lists.list(tagName), attributes);
        }

        public static HtmlPath collapsibleElement(List<string> tagNames, Map<string, string> attributes)
        {
            var tag = new HtmlTag(tagNames, attributes, true, "");
            return new HtmlPathElements(Lists.list(new HtmlPathElement(tag)));
        }
    }
}
