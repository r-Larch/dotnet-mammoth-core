namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal bool _isHeader;
        internal TableRow(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children, bool isHeader) {
            this._children = children;
            this._isHeader = isHeader;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
        public bool isHeader() {
            return this._isHeader;
        }
    }
}

