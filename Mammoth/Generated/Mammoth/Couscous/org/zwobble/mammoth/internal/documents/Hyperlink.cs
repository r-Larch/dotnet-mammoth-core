using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Hyperlink : DocumentElement, HasChildren {
        internal Optional<string> _anchor;
        internal List<DocumentElement> _children;
        internal Optional<string> _href;
        internal Optional<string> _targetFrame;

        internal Hyperlink(Optional<string> href, Optional<string> anchor, Optional<string> targetFrame, List<DocumentElement> children)
        {
            _href = href;
            _anchor = anchor;
            _targetFrame = targetFrame;
            _children = children;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public List<DocumentElement> getChildren()
        {
            return _children;
        }

        public static Hyperlink href(string href, Optional<string> targetFrame, List<DocumentElement> children)
        {
            return new Hyperlink(Optional.of(href), Optional.empty<string>(), targetFrame, children);
        }

        public static Hyperlink anchor(string anchor, Optional<string> targetFrame, List<DocumentElement> children)
        {
            return new Hyperlink(Optional.empty<string>(), Optional.of(anchor), targetFrame, children);
        }

        public Optional<string> getHref()
        {
            return _href;
        }

        public Optional<string> getAnchor()
        {
            return _anchor;
        }

        public Optional<string> getTargetFrame()
        {
            return _targetFrame;
        }
    }
}
