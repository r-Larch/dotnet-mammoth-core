namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Paragraph : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent _indent;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Paragraph(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._style = style;
            this._numbering = numbering;
            this._indent = indent;
            this._children = children;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> getNumbering() {
            return this._numbering;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent getIndent() {
            return this._indent;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

