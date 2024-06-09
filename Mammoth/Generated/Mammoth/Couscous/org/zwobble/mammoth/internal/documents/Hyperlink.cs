using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Hyperlink : IDocumentElement, IHasChildren {
        private IOptional<string> _anchor;
        private IList<IDocumentElement> _children;
        private IOptional<string> _href;
        private IOptional<string> _targetFrame;

        internal Hyperlink(IOptional<string> href, IOptional<string> anchor, IOptional<string> targetFrame, IList<IDocumentElement> children)
        {
            _href = href;
            _anchor = anchor;
            _targetFrame = targetFrame;
            _children = children;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public static Hyperlink Href(string href, IOptional<string> targetFrame, IList<IDocumentElement> children)
        {
            return new Hyperlink(Optional.Of(href), Optional.Empty<string>(), targetFrame, children);
        }

        public static Hyperlink Anchor(string anchor, IOptional<string> targetFrame, IList<IDocumentElement> children)
        {
            return new Hyperlink(Optional.Empty<string>(), Optional.Of(anchor), targetFrame, children);
        }

        public IOptional<string> GetHref()
        {
            return _href;
        }

        public IOptional<string> GetAnchor()
        {
            return _anchor;
        }

        public IOptional<string> GetTargetFrame()
        {
            return _targetFrame;
        }
    }
}
