using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, bool isSmallCaps, VerticalAlignment verticalAlignment, IOptional<Style> style, IList<IDocumentElement> children)
        : IDocumentElement, IHasChildren {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return children;
        }

        public bool IsBold()
        {
            return isBold;
        }

        public bool IsItalic()
        {
            return isItalic;
        }

        public bool IsUnderline()
        {
            return isUnderline;
        }

        public bool IsStrikethrough()
        {
            return isStrikethrough;
        }

        public bool IsSmallCaps()
        {
            return isSmallCaps;
        }

        public VerticalAlignment GetVerticalAlignment()
        {
            return verticalAlignment;
        }

        public IOptional<Style> GetStyle()
        {
            return style;
        }
    }
}
