using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous5 : IBiFunction<HtmlElement, HtmlElement, bool> {
        public bool Apply(HtmlElement last, HtmlElement next)
        {
            if (next.IsCollapsible() && Html.IsMatch(last, next)) {
                var separator = next.GetSeparator();
                if (!separator.IsEmpty()) {
                    (last.GetChildren()).Add(Html.Text(separator));
                }

                {
                    var couscousDesugarForeachToFor4 = (next.GetChildren()).Iterator();
                    while (couscousDesugarForeachToFor4.HasNext()) {
                        var child = couscousDesugarForeachToFor4.Next();
                        Html.CollapsingAdd(last.GetChildren(), child);
                    }
                }
                return true;
            }

            return false;
        }
    }
}
