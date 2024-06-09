using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableCell(int rowspan, int colspan, IList<IDocumentElement> children) : IDocumentElement, IHasChildren {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return children;
        }

        public int GetColspan()
        {
            return colspan;
        }

        public int GetRowspan()
        {
            return rowspan;
        }
    }
}
