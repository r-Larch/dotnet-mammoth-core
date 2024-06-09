using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_5 : BiFunction<HtmlElement, HtmlElement, bool> {
        public bool apply(HtmlElement last, HtmlElement next)
        {
            if (next.isCollapsible() && Html.isMatch(last, next)) {
                var separator = next.getSeparator();
                if (!separator.isEmpty()) {
                    (last.getChildren()).add(Html.text(separator));
                }

                {
                    var _couscous_desugar_foreach_to_for4 = (next.getChildren()).iterator();
                    while (_couscous_desugar_foreach_to_for4.hasNext()) {
                        var child = _couscous_desugar_foreach_to_for4.next();
                        Html.collapsingAdd(last.getChildren(), child);
                    }
                }
                return true;
            }

            return false;
        }
    }
}
