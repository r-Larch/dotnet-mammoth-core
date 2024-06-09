using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableCell : IDocumentElement, IHasChildren {
        private IList<IDocumentElement> _children;
        private int _colspan;
        private int _rowspan;

        internal TableCell(int rowspan, int colspan, IList<IDocumentElement> children)
        {
            _rowspan = rowspan;
            _children = children;
            _colspan = colspan;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public int GetColspan()
        {
            return _colspan;
        }

        public int GetRowspan()
        {
            return _rowspan;
        }
    }
}
