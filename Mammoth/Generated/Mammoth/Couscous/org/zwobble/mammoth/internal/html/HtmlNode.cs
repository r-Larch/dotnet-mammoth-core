namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode {
        void accept(HtmlNode__Visitor visitor);
        T accept<T>(HtmlNode__Mapper<T> visitor);
    }
}
