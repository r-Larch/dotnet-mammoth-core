namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching {
        public static bool matchesStyle(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleId(styleId, style) && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleName(styleName, style);
        }
        public static bool matchesStyleId(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<string, string>(styleId, style.map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_0()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_1());
        }
        public static bool matchesStyleName(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher, string>(styleName, style.flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_2()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_3());
        }
        public static bool matches<T, U>(Mammoth.Couscous.java.util.Optional<T> required, Mammoth.Couscous.java.util.Optional<U> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual) {
            return (required.map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_5<T, U>(actual, areEqual))).orElse(true);
        }
    }
}

