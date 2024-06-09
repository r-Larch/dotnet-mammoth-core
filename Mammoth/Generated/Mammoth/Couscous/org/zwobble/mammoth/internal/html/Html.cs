using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html {
        public static HtmlNode _FORCE_WRITE;

        static Html()
        {
            _FORCE_WRITE = HtmlForceWrite._FORCE_WRITE;
        }

        public static string write(List<HtmlNode> nodes)
        {
            var builder = new StringBuilder();
            nodes.forEach(new Html__Anonymous_0(builder));
            return builder.toString();
        }

        public static HtmlNode text(string value)
        {
            return new HtmlTextNode(value);
        }

        public static HtmlNode element(string tagName)
        {
            return element(tagName, Lists.list<HtmlNode>());
        }

        public static HtmlNode element(string tagName, Map<string, string> attributes)
        {
            return element(tagName, attributes, Lists.list<HtmlNode>());
        }

        public static HtmlNode element(string tagName, List<HtmlNode> children)
        {
            return element(tagName, Maps.map<string, string>(), children);
        }

        public static HtmlNode element(string tagName, Map<string, string> attributes, List<HtmlNode> children)
        {
            return new HtmlElement(new HtmlTag(Lists.list(tagName), attributes, false, ""), children);
        }

        public static HtmlNode collapsibleElement(string tagName)
        {
            return collapsibleElement(Lists.list(tagName));
        }

        public static HtmlNode collapsibleElement(List<string> tagNames)
        {
            return collapsibleElement(tagNames, Maps.map<string, string>(), Lists.list<HtmlNode>());
        }

        public static HtmlNode collapsibleElement(string tagName, List<HtmlNode> children)
        {
            return collapsibleElement(tagName, Maps.map<string, string>(), children);
        }

        public static HtmlNode collapsibleElement(string tagName, Map<string, string> attributes, List<HtmlNode> children)
        {
            return collapsibleElement(Lists.list(tagName), attributes, children);
        }

        public static HtmlNode collapsibleElement(List<string> tagNames, Map<string, string> attributes, List<HtmlNode> children)
        {
            return new HtmlElement(new HtmlTag(tagNames, attributes, true, ""), children);
        }

        public static List<HtmlNode> stripEmpty(List<HtmlNode> nodes)
        {
            return Lists.eagerFlatMap(nodes, new Html__Anonymous_1());
        }

        public static List<HtmlNode> stripEmpty(HtmlNode node)
        {
            return node.accept(new Html__Anonymous_2());
        }

        public static List<HtmlNode> collapse(List<HtmlNode> nodes)
        {
            List<HtmlNode> collapsed = new ArrayList<HtmlNode>();
            {
                var _couscous_desugar_foreach_to_for3 = nodes.iterator();
                while (_couscous_desugar_foreach_to_for3.hasNext()) {
                    var node = _couscous_desugar_foreach_to_for3.next();
                    collapsingAdd(collapsed, node);
                }
            }
            return collapsed;
        }

        public static void collapsingAdd(List<HtmlNode> collapsed, HtmlNode node)
        {
            var collapsedNode = collapse(node);
            if (!tryCollapse(collapsed, collapsedNode)) {
                collapsed.add(collapsedNode);
            }
        }

        public static HtmlNode collapse(HtmlNode node)
        {
            return node.accept(new Html__Anonymous_3());
        }

        public static bool tryCollapse(List<HtmlNode> collapsed, HtmlNode node)
        {
            return (Optionals.map((Lists.tryGetLast(collapsed)).flatMap(new Html__Anonymous_4()), Casts.tryCast<HtmlElement>(typeof(HtmlElement), node), new Html__Anonymous_5())).orElse(false);
        }

        public static bool isMatch(HtmlElement first, HtmlElement second)
        {
            return (second.getTagNames()).contains(first.getTagName()) && (first.getAttributes()).equals(second.getAttributes());
        }
    }
}
