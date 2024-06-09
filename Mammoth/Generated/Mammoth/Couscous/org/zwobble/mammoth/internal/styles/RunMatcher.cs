namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> _styleName;
        static RunMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        internal RunMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName) {
            this._styleId = styleId;
            this._styleName = styleName;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleName(string styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(styleName)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, run.getStyle());
        }
    }
}

