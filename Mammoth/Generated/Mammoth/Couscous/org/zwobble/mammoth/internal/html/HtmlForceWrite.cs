namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlForceWrite : HtmlNode {
        public static HtmlForceWrite _FORCE_WRITE;

        static HtmlForceWrite()
        {
            _FORCE_WRITE = new HtmlForceWrite();
        }

        public void accept(HtmlNode__Visitor visitor)
        {
            visitor.visit(this);
        }

        public T accept<T>(HtmlNode__Mapper<T> visitor)
        {
            return visitor.visit(this);
        }
    }
}
