using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html {
        public static IHtmlNode ForceWrite;

        static Html()
        {
            ForceWrite = HtmlForceWrite.ForceWrite;
        }

        public static string Write(IList<IHtmlNode> nodes)
        {
            var builder = new StringBuilder();
            nodes.ForEach(new HtmlAnonymous0(builder));
            return builder.ToString();
        }

        public static IHtmlNode Text(string value)
        {
            return new HtmlTextNode(value);
        }

        public static IHtmlNode Element(string tagName)
        {
            return Element(tagName, Lists.List<IHtmlNode>());
        }

        public static IHtmlNode Element(string tagName, IMap<string, string> attributes)
        {
            return Element(tagName, attributes, Lists.List<IHtmlNode>());
        }

        public static IHtmlNode Element(string tagName, IList<IHtmlNode> children)
        {
            return Element(tagName, Maps.Map<string, string>(), children);
        }

        public static IHtmlNode Element(string tagName, IMap<string, string> attributes, IList<IHtmlNode> children)
        {
            return new HtmlElement(new HtmlTag(Lists.List(tagName), attributes, false, ""), children);
        }

        public static IHtmlNode CollapsibleElement(string tagName)
        {
            return CollapsibleElement(Lists.List(tagName));
        }

        public static IHtmlNode CollapsibleElement(IList<string> tagNames)
        {
            return CollapsibleElement(tagNames, Maps.Map<string, string>(), Lists.List<IHtmlNode>());
        }

        public static IHtmlNode CollapsibleElement(string tagName, IList<IHtmlNode> children)
        {
            return CollapsibleElement(tagName, Maps.Map<string, string>(), children);
        }

        public static IHtmlNode CollapsibleElement(string tagName, IMap<string, string> attributes, IList<IHtmlNode> children)
        {
            return CollapsibleElement(Lists.List(tagName), attributes, children);
        }

        public static IHtmlNode CollapsibleElement(IList<string> tagNames, IMap<string, string> attributes, IList<IHtmlNode> children)
        {
            return new HtmlElement(new HtmlTag(tagNames, attributes, true, ""), children);
        }

        public static IList<IHtmlNode> StripEmpty(IList<IHtmlNode> nodes)
        {
            return Lists.EagerFlatMap(nodes, new HtmlAnonymous1());
        }

        public static IList<IHtmlNode> StripEmpty(IHtmlNode node)
        {
            return node.Accept(new HtmlAnonymous2());
        }

        public static IList<IHtmlNode> Collapse(IList<IHtmlNode> nodes)
        {
            IList<IHtmlNode> collapsed = new ArrayList<IHtmlNode>();
            {
                var couscousDesugarForeachToFor3 = nodes.Iterator();
                while (couscousDesugarForeachToFor3.HasNext()) {
                    var node = couscousDesugarForeachToFor3.Next();
                    CollapsingAdd(collapsed, node);
                }
            }
            return collapsed;
        }

        public static void CollapsingAdd(IList<IHtmlNode> collapsed, IHtmlNode node)
        {
            var collapsedNode = Collapse(node);
            if (!TryCollapse(collapsed, collapsedNode)) {
                collapsed.Add(collapsedNode);
            }
        }

        public static IHtmlNode Collapse(IHtmlNode node)
        {
            return node.Accept(new HtmlAnonymous3());
        }

        public static bool TryCollapse(IList<IHtmlNode> collapsed, IHtmlNode node)
        {
            return (Optionals.Map((Lists.TryGetLast(collapsed)).FlatMap(new HtmlAnonymous4()), Casts.TryCast<HtmlElement>(typeof(HtmlElement), node), new HtmlAnonymous5())).OrElse(false);
        }

        public static bool IsMatch(HtmlElement first, HtmlElement second)
        {
            return (second.GetTagNames()).Contains(first.GetTagName()) && (first.GetAttributes()).Equals(second.GetAttributes());
        }
    }
}
