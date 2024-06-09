namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode {
        void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor);
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor);
    }
}

