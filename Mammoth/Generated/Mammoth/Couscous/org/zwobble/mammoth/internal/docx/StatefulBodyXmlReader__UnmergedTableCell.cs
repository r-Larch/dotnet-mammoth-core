namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__UnmergedTableCell : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal bool _vmerge;
        internal int _colspan;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal StatefulBodyXmlReader__UnmergedTableCell(bool vmerge, int colspan, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._vmerge = vmerge;
            this._colspan = colspan;
            this._children = children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell(1, this._colspan, this._children), context);
        }
    }
}

