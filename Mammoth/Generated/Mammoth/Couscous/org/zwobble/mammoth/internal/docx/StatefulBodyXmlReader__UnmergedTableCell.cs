using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderUnmergedTableCell : IDocumentElement {
        public IList<IDocumentElement> Children;
        public int Colspan;
        public bool Vmerge;

        internal StatefulBodyXmlReaderUnmergedTableCell(bool vmerge, int colspan, IList<IDocumentElement> children)
        {
            Vmerge = vmerge;
            Colspan = colspan;
            Children = children;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(new TableCell(1, Colspan, Children), context);
        }
    }
}
