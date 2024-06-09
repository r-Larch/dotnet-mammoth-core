using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run : DocumentElement, HasChildren {
        internal List<DocumentElement> _children;
        internal bool _isBold;
        internal bool _isItalic;
        internal bool _isSmallCaps;
        internal bool _isStrikethrough;
        internal bool _isUnderline;
        internal Optional<Style> _style;
        internal VerticalAlignment _verticalAlignment;

        internal Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, bool isSmallCaps, VerticalAlignment verticalAlignment, Optional<Style> style, List<DocumentElement> children)
        {
            _isBold = isBold;
            _isItalic = isItalic;
            _isUnderline = isUnderline;
            _isStrikethrough = isStrikethrough;
            _isSmallCaps = isSmallCaps;
            _verticalAlignment = verticalAlignment;
            _style = style;
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

        public bool isBold()
        {
            return _isBold;
        }

        public bool isItalic()
        {
            return _isItalic;
        }

        public bool isUnderline()
        {
            return _isUnderline;
        }

        public bool isStrikethrough()
        {
            return _isStrikethrough;
        }

        public bool isSmallCaps()
        {
            return _isSmallCaps;
        }

        public VerticalAlignment getVerticalAlignment()
        {
            return _verticalAlignment;
        }

        public Optional<Style> getStyle()
        {
            return _style;
        }
    }
}
