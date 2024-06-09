using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow : IDocumentElement, IHasChildren {
        private IList<IDocumentElement> _children;
        private bool _isHeader;

        internal TableRow(IList<IDocumentElement> children, bool isHeader)
        {
            _children = children;
            _isHeader = isHeader;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public bool IsHeader()
        {
            return _isHeader;
        }
    }
}
