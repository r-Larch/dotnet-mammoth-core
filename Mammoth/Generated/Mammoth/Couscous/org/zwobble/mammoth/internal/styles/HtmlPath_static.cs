using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathStatic {
        public static IHtmlPath Empty = new HtmlPathElements(Lists.List<HtmlPathElement>());
        public static IHtmlPath Ignore = styles.Ignore.Instance;

        public static IHtmlPath Elements(HtmlPathElement[] elements)
        {
            return new HtmlPathElements(Arrays.AsList(elements));
        }

        public static IHtmlPath Element(string tagName)
        {
            return Element(tagName, Maps.Map<string, string>());
        }

        public static IHtmlPath Element(string tagName, IMap<string, string> attributes)
        {
            var tag = new HtmlTag(Lists.List(tagName), attributes, false, "");
            return new HtmlPathElements(Lists.List(new HtmlPathElement(tag)));
        }

        public static IHtmlPath CollapsibleElement(string tagName)
        {
            return CollapsibleElement(tagName, Maps.Map<string, string>());
        }

        public static IHtmlPath CollapsibleElement(IList<string> tagNames)
        {
            return CollapsibleElement(tagNames, Maps.Map<string, string>());
        }

        public static IHtmlPath CollapsibleElement(string tagName, IMap<string, string> attributes)
        {
            return CollapsibleElement(Lists.List(tagName), attributes);
        }

        public static IHtmlPath CollapsibleElement(IList<string> tagNames, IMap<string, string> attributes)
        {
            var tag = new HtmlTag(tagNames, attributes, true, "");
            return new HtmlPathElements(Lists.List(new HtmlPathElement(tag)));
        }
    }
}
