namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class StyleMapping {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T> {
        private IHtmlPath _htmlPath;
        private IDocumentElementMatcher<T> _matcher;

        internal StyleMapping(IDocumentElementMatcher<T> matcher, IHtmlPath htmlPath)
        {
            _matcher = matcher;
            _htmlPath = htmlPath;
        }

        public bool Matches(T element)
        {
            return (_matcher).Matches(element);
        }

        public IHtmlPath GetHtmlPath()
        {
            return _htmlPath;
        }
    }
}
