namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableCell : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal int _rowspan;
        internal int _colspan;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal TableCell(int rowspan, int colspan, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._rowspan = rowspan;
            this._children = children;
            this._colspan = colspan;
        }
        public int getColspan() {
            return this._colspan;
        }
        public int getRowspan() {
            return this._rowspan;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

