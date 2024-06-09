namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_6 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent _indent;
        internal StatefulBodyXmlReader__Anonymous_6(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent) {
            this._numbering = numbering;
            this._indent = indent;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph(style, this._numbering, this._indent, children);
        }
    }
}

