namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class StyleMapping {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T> {
        internal HtmlPath _htmlPath;
        internal DocumentElementMatcher<T> _matcher;

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
