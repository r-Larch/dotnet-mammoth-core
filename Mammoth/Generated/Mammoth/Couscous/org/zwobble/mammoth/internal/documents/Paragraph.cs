using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Paragraph(IOptional<Style> style, IOptional<NumberingLevel> numbering, ParagraphIndent indent, IList<IDocumentElement> children)
        : IDocumentElement, IHasChildren {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return children;
        }

        public IOptional<Style> GetStyle()
        {
            return style;
        }

        public IOptional<NumberingLevel> GetNumbering()
        {
            return numbering;
        }

        public ParagraphIndent GetIndent()
        {
            return indent;
        }
    }
}
