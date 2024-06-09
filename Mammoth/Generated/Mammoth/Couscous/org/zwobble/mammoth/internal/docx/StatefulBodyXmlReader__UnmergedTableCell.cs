using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__UnmergedTableCell : DocumentElement {
        internal List<DocumentElement> _children;
        internal int _colspan;
        internal bool _vmerge;

        internal StatefulBodyXmlReader__UnmergedTableCell(bool vmerge, int colspan, List<DocumentElement> children)
        {
            _vmerge = vmerge;
            _colspan = colspan;
            _children = children;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(new TableCell(1, _colspan, _children), context);
        }
    }
}
