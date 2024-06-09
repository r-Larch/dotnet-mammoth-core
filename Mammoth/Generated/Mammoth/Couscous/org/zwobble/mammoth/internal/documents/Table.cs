using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Table : DocumentElement, HasChildren {
        internal List<DocumentElement> _children;
        internal Optional<Style> _style;

        internal Table(Optional<Style> style, List<DocumentElement> children)
        {
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

        public Optional<Style> getStyle()
        {
            return _style;
        }
    }
}
