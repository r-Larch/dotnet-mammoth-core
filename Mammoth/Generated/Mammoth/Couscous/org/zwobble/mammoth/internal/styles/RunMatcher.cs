using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher(IOptional<string> styleId, IOptional<IStringMatcher> styleName) : IDocumentElementMatcher<Run> {
        public static RunMatcher Any = new(Optional.Empty<string>(), Optional.Empty<IStringMatcher>());

        public bool Matches(Run run)
        {
            return DocumentElementMatching.MatchesStyle(styleId, styleName, run.GetStyle());
        }

        public static RunMatcher StyleId(string styleId)
        {
            return new RunMatcher(Optional.Of(styleId), Optional.Empty<IStringMatcher>());
        }

        public static RunMatcher StyleName(string styleName)
        {
            return new RunMatcher(Optional.Empty<string>(), Optional.Of<IStringMatcher>(new EqualToStringMatcher(styleName)));
        }
    }
}
