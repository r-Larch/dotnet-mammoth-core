using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement : IHtmlNode {
        private static ISet<string> _voidTagNames;
        private IList<IHtmlNode> _children;
        private HtmlTag _tag;

        static HtmlElement()
        {
            _voidTagNames = Sets.Set(new[] { "img", "br", "hr" });
        }

        internal HtmlElement(HtmlTag tag, IList<IHtmlNode> children)
        {
            _tag = tag;
            _children = children;
        }

        public void Accept(IHtmlNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(IHtmlNodeMapper<T> visitor)
        {
            return visitor.Visit(this);
        }

        public HtmlTag GetTag()
        {
            return _tag;
        }

        public IList<string> GetTagNames()
        {
            return (_tag).GetTagNames();
        }

        public string GetTagName()
        {
            return (GetTagNames()).Get(0);
        }

        public IMap<string, string> GetAttributes()
        {
            return (_tag).GetAttributes();
        }

        public IList<IHtmlNode> GetChildren()
        {
            return _children;
        }

        public bool IsCollapsible()
        {
            return (_tag).IsCollapsible();
        }

        public string GetSeparator()
        {
            return (_tag).GetSeparator();
        }

        public bool IsVoid()
        {
            return (_children).IsEmpty() && IsVoidTag(GetTagName());
        }

        public static bool IsVoidTag(string tagName)
        {
            return (_voidTagNames).Contains(tagName);
        }
    }
}
