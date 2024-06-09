namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T>(IDocumentElementMatcher<T> matcher, IHtmlPath htmlPath) {
        public bool Matches(T element)
        {
            return matcher.Matches(element);
        }

        public IHtmlPath GetHtmlPath()
        {
            return htmlPath;
        }
    }
}
