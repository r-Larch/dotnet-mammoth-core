using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement : HtmlNode {
        internal static Set<string> _VOID_TAG_NAMES;
        internal List<HtmlNode> _children;
        internal HtmlTag _tag;

        static HtmlElement()
        {
            _VOID_TAG_NAMES = Sets.set(new[] { "img", "br", "hr" });
        }

        internal HtmlElement(HtmlTag tag, List<HtmlNode> children)
        {
            _tag = tag;
            _children = children;
        }

        public void accept(HtmlNode__Visitor visitor)
        {
            visitor.visit(this);
        }

        public T accept<T>(HtmlNode__Mapper<T> visitor)
        {
            return visitor.visit(this);
        }

        public HtmlTag getTag()
        {
            return _tag;
        }

        public List<string> getTagNames()
        {
            return (_tag).getTagNames();
        }

        public string getTagName()
        {
            return (getTagNames()).get(0);
        }

        public Map<string, string> getAttributes()
        {
            return (_tag).getAttributes();
        }

        public List<HtmlNode> getChildren()
        {
            return _children;
        }

        public bool isCollapsible()
        {
            return (_tag).isCollapsible();
        }

        public string getSeparator()
        {
            return (_tag).getSeparator();
        }

        public bool isVoid()
        {
            return (_children).isEmpty() && isVoidTag(getTagName());
        }

        public static bool isVoidTag(string tagName)
        {
            return (_VOID_TAG_NAMES).contains(tagName);
        }
    }
}
