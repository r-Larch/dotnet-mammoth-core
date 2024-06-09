namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class StyleMapping {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T> {
        private HtmlPath _htmlPath;
        private DocumentElementMatcher<T> _matcher;

        internal StyleMapping(DocumentElementMatcher<T> matcher, HtmlPath htmlPath)
        {
            _matcher = matcher;
            _htmlPath = htmlPath;
        }

        public bool matches(T element)
        {
            return (_matcher).matches(element);
        }

        public HtmlPath getHtmlPath()
        {
            return _htmlPath;
        }
    }
}
