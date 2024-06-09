using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow(IList<IDocumentElement> children, bool isHeader) : IDocumentElement, IHasChildren {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return children;
        }

        public bool IsHeader()
        {
            return isHeader;
        }
    }
}
