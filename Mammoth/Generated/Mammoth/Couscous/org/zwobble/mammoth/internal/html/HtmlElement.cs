namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag _tag;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _children;
        internal static Mammoth.Couscous.java.util.Set<string> _VOID_TAG_NAMES;
        static HtmlElement() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement._VOID_TAG_NAMES = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.set<string>(new string[] {"img", "br", "hr"});
        }
        internal HtmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            this._tag = tag;
            this._children = children;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag getTag() {
            return this._tag;
        }
        public Mammoth.Couscous.java.util.List<string> getTagNames() {
            return (this._tag).getTagNames();
        }
        public string getTagName() {
            return (this.getTagNames()).get(0);
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return (this._tag).getAttributes();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> getChildren() {
            return this._children;
        }
        public bool isCollapsible() {
            return (this._tag).isCollapsible();
        }
        public string getSeparator() {
            return (this._tag).getSeparator();
        }
        public bool isVoid() {
            return (this._children).isEmpty() && Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement.isVoidTag(this.getTagName());
        }
        public static bool isVoidTag(string tagName) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement._VOID_TAG_NAMES).contains(tagName);
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

