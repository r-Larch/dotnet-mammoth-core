namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Table : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Table(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._style = style;
            this._children = children;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

