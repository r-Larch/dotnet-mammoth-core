namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode _FORCE_WRITE;
        static Html() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite._FORCE_WRITE;
        }
        public static string write(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.lang.StringBuilder builder = new Mammoth.Couscous.java.lang.StringBuilder();
            nodes.forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_0(builder));
            return builder.toString();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode text(string value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode(value);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, false, ""), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(tagNames, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, true, ""), children);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_2());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for3 = nodes.iterator();
                while (_couscous_desugar_foreach_to_for3.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node = _couscous_desugar_foreach_to_for3.next();
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(collapsed, node);
                }
            }
            return collapsed;
        }
        public static void collapsingAdd(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsedNode = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(node);
            if (!Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.tryCollapse(collapsed, collapsedNode)) {
                collapsed.add(collapsedNode);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapse(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return node.accept<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_3());
        }
        public static bool tryCollapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.map<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool>((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(collapsed)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_4()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement), node), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_5())).orElse(false);
        }
        public static bool isMatch(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement first, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement second) {
            return (second.getTagNames()).contains(first.getTagName()) && (first.getAttributes()).equals(second.getAttributes());
        }
    }
}

