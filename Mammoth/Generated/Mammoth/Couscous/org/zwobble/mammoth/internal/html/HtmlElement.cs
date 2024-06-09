using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement(HtmlTag tag, IList<IHtmlNode> children) : IHtmlNode {
        private static readonly ISet<string> VoidTagNames = Sets.Set(["img", "br", "hr"]);

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
            return tag;
        }

        public IList<string> GetTagNames()
        {
            return tag.GetTagNames();
        }

        public string GetTagName()
        {
            return GetTagNames().Get(0);
        }

        public IMap<string, string> GetAttributes()
        {
            return tag.GetAttributes();
        }

        public IList<IHtmlNode> GetChildren()
        {
            return children;
        }

        public bool IsCollapsible()
        {
            return tag.IsCollapsible();
        }

        public string GetSeparator()
        {
            return tag.GetSeparator();
        }

        public bool IsVoid()
        {
            return children.IsEmpty() && IsVoidTag(GetTagName());
        }

        public static bool IsVoidTag(string tagName)
        {
            return VoidTagNames.Contains(tagName);
        }
    }
}
