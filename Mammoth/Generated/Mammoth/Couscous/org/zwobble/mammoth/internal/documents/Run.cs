using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run : IDocumentElement, IHasChildren {
        private IList<IDocumentElement> _children;
        private bool _isBold;
        private bool _isItalic;
        private bool _isSmallCaps;
        private bool _isStrikethrough;
        private bool _isUnderline;
        private IOptional<Style> _style;
        private VerticalAlignment _verticalAlignment;

        internal Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, bool isSmallCaps, VerticalAlignment verticalAlignment, IOptional<Style> style, IList<IDocumentElement> children)
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

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public bool IsBold()
        {
            return _isBold;
        }

        public bool IsItalic()
        {
            return _isItalic;
        }

        public bool IsUnderline()
        {
            return _isUnderline;
        }

        public bool IsStrikethrough()
        {
            return _isStrikethrough;
        }

        public bool IsSmallCaps()
        {
            return _isSmallCaps;
        }

        public VerticalAlignment GetVerticalAlignment()
        {
            return _verticalAlignment;
        }

        public IOptional<Style> GetStyle()
        {
            return _style;
        }
    }
}
