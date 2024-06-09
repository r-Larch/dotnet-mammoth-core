namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal bool _isBold;
        internal bool _isItalic;
        internal bool _isUnderline;
        internal bool _isStrikethrough;
        internal bool _isSmallCaps;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment _verticalAlignment;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, bool isSmallCaps, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment verticalAlignment, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._isBold = isBold;
            this._isItalic = isItalic;
            this._isUnderline = isUnderline;
            this._isStrikethrough = isStrikethrough;
            this._isSmallCaps = isSmallCaps;
            this._verticalAlignment = verticalAlignment;
            this._style = style;
            this._children = children;
        }
        public bool isBold() {
            return this._isBold;
        }
        public bool isItalic() {
            return this._isItalic;
        }
        public bool isUnderline() {
            return this._isUnderline;
        }
        public bool isStrikethrough() {
            return this._isStrikethrough;
        }
        public bool isSmallCaps() {
            return this._isSmallCaps;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment getVerticalAlignment() {
            return this._verticalAlignment;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

