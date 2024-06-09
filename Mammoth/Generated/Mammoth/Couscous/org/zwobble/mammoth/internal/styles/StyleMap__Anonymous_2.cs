namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal StyleMap__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            this._run = run;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> styleMapping) {
            return styleMapping.matches(this._run);
        }
    }
}

