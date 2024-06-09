namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Hyperlink : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<string> _href;
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Hyperlink(Mammoth.Couscous.java.util.Optional<string> href, Mammoth.Couscous.java.util.Optional<string> anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._href = href;
            this._anchor = anchor;
            this._targetFrame = targetFrame;
            this._children = children;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink href(string href, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.of<string>(href), Mammoth.Couscous.java.util.Optional.empty<string>(), targetFrame, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink anchor(string anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<string>(anchor), targetFrame, children);
        }
        public Mammoth.Couscous.java.util.Optional<string> getHref() {
            return this._href;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAnchor() {
            return this._anchor;
        }
        public Mammoth.Couscous.java.util.Optional<string> getTargetFrame() {
            return this._targetFrame;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

