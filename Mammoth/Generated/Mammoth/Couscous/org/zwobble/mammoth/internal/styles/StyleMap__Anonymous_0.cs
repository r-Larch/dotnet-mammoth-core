namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal StyleMap__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            this._paragraph = paragraph;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> styleMapping) {
            return styleMapping.matches(this._paragraph);
        }
    }
}

