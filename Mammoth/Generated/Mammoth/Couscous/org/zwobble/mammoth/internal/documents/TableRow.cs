using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow : DocumentElement, HasChildren {
        internal List<DocumentElement> _children;
        internal bool _isHeader;

        internal TableRow(List<DocumentElement> children, bool isHeader)
        {
            _children = children;
            _isHeader = isHeader;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public List<DocumentElement> getChildren()
        {
            return _children;
        }

        public bool isHeader()
        {
            return _isHeader;
        }
    }
}
