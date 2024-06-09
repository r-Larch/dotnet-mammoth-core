namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_6 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _breakElement;
        internal StyleMap__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            this._breakElement = breakElement;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> styleMapping) {
            return styleMapping.matches(this._breakElement);
        }
    }
}

