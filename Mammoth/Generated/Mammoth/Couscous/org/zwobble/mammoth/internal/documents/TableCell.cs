using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableCell : DocumentElement, HasChildren {
        private List<DocumentElement> _children;
        private int _colspan;
        private int _rowspan;

        internal TableCell(int rowspan, int colspan, List<DocumentElement> children)
        {
            _rowspan = rowspan;
            _children = children;
            _colspan = colspan;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public List<DocumentElement> getChildren()
        {
            return _children;
        }

        public int getColspan()
        {
            return _colspan;
        }

        public int getRowspan()
        {
            return _rowspan;
        }
    }
}
