using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Hyperlink(IOptional<string> href, IOptional<string> anchor, IOptional<string> targetFrame, IList<IDocumentElement> children)
        : IDocumentElement, IHasChildren {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return children;
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
            return href;
        }

        public IOptional<string> GetAnchor()
        {
            return anchor;
        }

        public IOptional<string> GetTargetFrame()
        {
            return targetFrame;
        }
    }
}
