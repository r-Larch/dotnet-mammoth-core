using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching {
        public static bool matchesStyle(Optional<string> styleId, Optional<StringMatcher> styleName, Optional<Style> style)
        {
            return matchesStyleId(styleId, style) && matchesStyleName(styleName, style);
        }

        public static bool matchesStyleId(Optional<string> styleId, Optional<Style> style)
        {
            return matches(styleId, style.map(new DocumentElementMatching__Anonymous_0()), new DocumentElementMatching__Anonymous_1());
        }

        public static bool matchesStyleName(Optional<StringMatcher> styleName, Optional<Style> style)
        {
            return matches(styleName, style.flatMap(new DocumentElementMatching__Anonymous_2()), new DocumentElementMatching__Anonymous_3());
        }

        public static bool matches<T, U>(Optional<T> required, Optional<U> actual, BiPredicate<T, U> areEqual)
        {
            return (required.map(new DocumentElementMatching__Anonymous_5<T, U>(actual, areEqual))).orElse(true);
        }
    }
}
