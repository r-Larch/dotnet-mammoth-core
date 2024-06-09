using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching {
        public static bool MatchesStyle(IOptional<string> styleId, IOptional<IStringMatcher> styleName, IOptional<Style> style)
        {
            return MatchesStyleId(styleId, style) && MatchesStyleName(styleName, style);
        }

        public static bool MatchesStyleId(IOptional<string> styleId, IOptional<Style> style)
        {
            return Matches(styleId, style.Map(new DocumentElementMatchingAnonymous0()), new DocumentElementMatchingAnonymous1());
        }

        public static bool MatchesStyleName(IOptional<IStringMatcher> styleName, IOptional<Style> style)
        {
            return Matches(styleName, style.FlatMap(new DocumentElementMatchingAnonymous2()), new DocumentElementMatchingAnonymous3());
        }

        public static bool Matches<T, TU>(IOptional<T> required, IOptional<TU> actual, IBiPredicate<T, TU> areEqual)
        {
            return required.Map(new DocumentElementMatchingAnonymous5<T, TU>(actual, areEqual)).OrElse(true);
        }
    }
}
