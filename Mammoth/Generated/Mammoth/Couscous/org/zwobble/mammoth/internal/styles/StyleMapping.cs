namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class StyleMapping {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<T> _matcher;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _htmlPath;
        internal StyleMapping(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<T> matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath) {
            this._matcher = matcher;
            this._htmlPath = htmlPath;
        }
        public bool matches(T element) {
            return (this._matcher).matches(element);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath getHtmlPath() {
            return this._htmlPath;
        }
    }
}

