using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Paragraph : IDocumentElement, IHasChildren {
        private IList<IDocumentElement> _children;
        private ParagraphIndent _indent;
        private IOptional<NumberingLevel> _numbering;
        private IOptional<Style> _style;

        internal Paragraph(IOptional<Style> style, IOptional<NumberingLevel> numbering, ParagraphIndent indent, IList<IDocumentElement> children)
        {
            _style = style;
            _numbering = numbering;
            _indent = indent;
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

        public IOptional<Style> GetStyle()
        {
            return _style;
        }

        public IOptional<NumberingLevel> GetNumbering()
        {
            return _numbering;
        }

        public ParagraphIndent GetIndent()
        {
            return _indent;
        }
    }
}
