namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlForceWrite : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite _FORCE_WRITE;
        static HtmlForceWrite() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite._FORCE_WRITE = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite();
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

