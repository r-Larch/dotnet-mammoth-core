using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Paragraph : DocumentElement, HasChildren {
        private List<DocumentElement> _children;
        private ParagraphIndent _indent;
        private Optional<NumberingLevel> _numbering;
        private Optional<Style> _style;

        internal Paragraph(Optional<Style> style, Optional<NumberingLevel> numbering, ParagraphIndent indent, List<DocumentElement> children)
        {
            _style = style;
            _numbering = numbering;
            _indent = indent;
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

        public Optional<Style> getStyle()
        {
            return _style;
        }

        public Optional<NumberingLevel> getNumbering()
        {
            return _numbering;
        }

        public ParagraphIndent getIndent()
        {
            return _indent;
        }
    }
}
