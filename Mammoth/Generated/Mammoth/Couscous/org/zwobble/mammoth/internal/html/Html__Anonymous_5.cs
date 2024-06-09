namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_5 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement last, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement next) {
            if (next.isCollapsible() && Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.isMatch(last, next)) {
                string separator = next.getSeparator();
                if (!separator.isEmpty()) {
                    (last.getChildren()).add(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(separator));
                }
                 {
                    Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for4 = (next.getChildren()).iterator();
                    while (_couscous_desugar_foreach_to_for4.hasNext()) {
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child = _couscous_desugar_foreach_to_for4.next();
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(last.getChildren(), child);
                    }
                }
                return true;
            } else {
                return false;
            }
        }
    }
}

